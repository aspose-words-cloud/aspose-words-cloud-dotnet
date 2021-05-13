// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiInvoker.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.WebUtilities;
    using Microsoft.Extensions.Primitives;

    internal class ApiInvoker
    {
        private const string AsposeClientHeaderName = "x-aspose-client";
        private const string AsposeClientVersionHeaderName = "x-aspose-client-version";
        private readonly Dictionary<string, string> defaultHeaderMap = new Dictionary<string, string>();
        private readonly List<IRequestHandler> requestHandlers;
        private HttpClient httpClient;

        public ApiInvoker(List<IRequestHandler> requestHandlers)
        {
            this.AddDefaultHeader(AsposeClientHeaderName, ".net sdk");
            this.AddDefaultHeader(AsposeClientVersionHeaderName, "21.5");
            this.requestHandlers = requestHandlers;
            this.httpClient = new HttpClient();
        }

        internal static HttpContent GetBodyParameterData(object param)
        {
            HttpContent result = null;
            if (param is FileInfo)
            {
                result = new ByteArrayContent(((FileInfo)param).FileContent);
            }
            else
            {
                string postData = SerializationHelper.Serialize(param);
                result = new StringContent(postData, Encoding.UTF8, "application/json");
            }

            return result;
        }

        internal static MultipartContent GetMultipartFormData(Dictionary<string, object> postParameters)
        {
            var multipart = new MultipartFormDataContent();
            foreach (var param in postParameters)
            {
                if (param.Value is FileInfo)
                {
                    var fileInfo = (FileInfo)param.Value;
                    multipart.Add(new ByteArrayContent(fileInfo.FileContent), param.Key, param.Key);
                }
                else
                {
                    string stringData;
                    if (param.Value is string)
                    {
                        stringData = (string)param.Value;
                    }
                    else
                    {
                        stringData = SerializationHelper.Serialize(param.Value);
                    }

                    multipart.Add(new StringContent(stringData, Encoding.UTF8, "application/json"), param.Key);
                }
            }

            return multipart;
        }

        internal static HttpResponseMessage[] ToMultipartResponse(HttpResponseMessage response)
        {
            try
            {
                var boundary = response.Content.Headers.ContentType.Parameters
                    .FirstOrDefault(a => string.Equals(a.Name, "boundary", StringComparison.OrdinalIgnoreCase))?.Value.Trim('"');
                var reader = new MultipartReader(boundary, response.Content.ReadAsStreamAsync().GetAwaiter().GetResult());

                var result = new List<HttpResponseMessage>();
                HttpResponseMessage childResponse;
                while ((childResponse = ApiInvoker.ReadNextChildResponseAsync(reader).GetAwaiter().GetResult()) != null)
                {
                    result.Add(childResponse);
                }

                return result.ToArray();
            }
            catch (Exception ex)
            {
                throw new ApiException(400, "Failed to read multipart response: " + ex.Message);
            }
        }

        internal static Dictionary<string, Stream> ToMultipartForm(HttpResponseMessage response)
        {
            try
            {
                var boundary = response.Content.Headers.ContentType.Parameters
                    .FirstOrDefault(a => string.Equals(a.Name, "boundary", StringComparison.OrdinalIgnoreCase))?.Value.Trim('"');
                var reader = new MultipartReader(boundary, response.Content.ReadAsStreamAsync().GetAwaiter().GetResult());

                var result = new Dictionary<string, Stream>();
                MultipartSection childSection;
                while ((childSection = reader.ReadNextSectionAsync().GetAwaiter().GetResult()) != null)
                {
                    string partName = null;
                    var contentHeaders = childSection.ContentDisposition.Split(';');
                    foreach (var contentHeader in contentHeaders)
                    {
                        var contentHeaderParts = contentHeader.Split('=');
                        if (contentHeaderParts.Length == 2)
                        {
                            if (contentHeaderParts[0].Trim().Equals("name"))
                            {
                                partName = contentHeaderParts[1].Trim();
                                break;
                            }
                        }
                    }

                    if (partName != null)
                    {
                        var ms = new MemoryStream();
                        childSection.Body.CopyTo(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        result.Add(partName, ms);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException(400, "Failed to read multipart response: " + ex.Message);
            }
        }

        internal HttpResponseMessage InvokeApi(System.Func<HttpRequestMessage> httpRequestFactory)
        {
            try
            {
                return this.InvokeApiInternal(httpRequestFactory());
            }
            catch (NeedRepeatRequestException)
            {
                try
                {
                    return this.InvokeApiInternal(httpRequestFactory());
                }
                catch (NeedRepeatRequestException)
                {
                    throw new ApiException(401, "Authorization failed");
                }
            }
        }

        private static async Task<HttpResponseMessage> ReadNextChildResponseAsync(MultipartReader reader, CancellationToken cancellationToken = default(CancellationToken))
        {
            var section = await reader.ReadNextSectionAsync(cancellationToken).ConfigureAwait(false);
            if (section == null)
            {
                return null;
            }

            var bufferedStream = new BufferedReadStream(section.Body, 4096);
            var line = await bufferedStream.ReadLineAsync(MultipartReader.DefaultHeadersLengthLimit, cancellationToken).ConfigureAwait(false);
            var requestLineParts = line.Split(' ');
            if (requestLineParts.Length < 2)
            {
                throw new InvalidDataException("Invalid response line.");
            }

            var headers = await ApiInvoker.ReadHeadersAsync(bufferedStream, cancellationToken).ConfigureAwait(false);

            var response = new HttpResponseMessage();

            HttpStatusCode statusCode;
            if (Enum.TryParse(requestLineParts[0], out statusCode))
            {
                response.StatusCode = statusCode;
            }

            var contentStream = new MemoryStream();
            await bufferedStream.CopyToAsync(contentStream);
            contentStream.Position = 0;
            response.Content = new StreamContent(contentStream);

            foreach (var header in headers)
            {
                if (!response.Content.Headers.Contains(header.Key))
                {
                    response.Content.Headers.Add(header.Key, header.Value.ToArray());
                }
            }

            return response;
        }

        private static async Task<Dictionary<string, StringValues>> ReadHeadersAsync(BufferedReadStream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            var totalSize = 0;
            var accumulator = default(KeyValueAccumulator);
            var line = await stream.ReadLineAsync(MultipartReader.DefaultHeadersLengthLimit, cancellationToken).ConfigureAwait(false);
            while (!string.IsNullOrEmpty(line))
            {
                if (MultipartReader.DefaultHeadersLengthLimit - totalSize < line.Length)
                {
                    throw new InvalidDataException(
                        $"Multipart headers length limit {MultipartReader.DefaultHeadersLengthLimit} exceeded.");
                }

                totalSize += line.Length;
                var splitIndex = line.IndexOf(':');
                if (splitIndex <= 0)
                {
                    throw new InvalidDataException($"Invalid header line: {line}");
                }

                var name = line.Substring(0, splitIndex);
                var value = line.Substring(splitIndex + 1, line.Length - splitIndex - 1).Trim();
                accumulator.Append(name, value);
                if (accumulator.KeyCount > MultipartReader.DefaultHeadersCountLimit)
                {
                    throw new InvalidDataException(
                        $"Multipart headers count limit {MultipartReader.DefaultHeadersCountLimit} exceeded.");
                }

                line = await stream.ReadLineAsync(MultipartReader.DefaultHeadersLengthLimit - totalSize, cancellationToken).ConfigureAwait(false);
            }

            return accumulator.GetResults();
        }

        private void AddDefaultHeader(string key, string value)
        {
            if (!this.defaultHeaderMap.ContainsKey(key))
            {
                this.defaultHeaderMap.Add(key, value);
            }
        }

        private HttpResponseMessage InvokeApiInternal(HttpRequestMessage httpRequest)
        {
            foreach (var defaultHeader in this.defaultHeaderMap)
            {
                if (httpRequest.Headers.Contains(defaultHeader.Key))
                {
                    httpRequest.Headers.Remove(defaultHeader.Key);
                }

                httpRequest.Headers.Add(defaultHeader.Key, defaultHeader.Value);
            }

            this.requestHandlers.ForEach(p => p.ProcessRequest(httpRequest));
            var response = this.httpClient.SendAsync(httpRequest).GetAwaiter().GetResult();

            try
            {
                this.requestHandlers.ForEach(p => p.ProcessResponse(response));
                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
