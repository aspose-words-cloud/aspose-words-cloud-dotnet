// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertDocumentRequest.cs">
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

namespace Aspose.Words.Cloud.Sdk.Model.Requests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Responses;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ConvertDocument" /> operation.
    /// </summary>
    public class ConvertDocumentRequest : IRequestModel, ICanUseCustomFontsRequest, ICanSpecifyOutputFormatRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
        /// </summary>
        public ConvertDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentRequest"/> class.
        /// </summary>
        /// <param name="document">Converting document.</param>
        /// <param name="format">The format to convert.</param>
        /// <param name="outPath">The path to the output document on a local storage.</param>
        /// <param name="fileNameFieldValue">The filename of the output document, that will be used when the resulting document has a dynamic field {filename}. If it is not set, the "sourceFilename" will be used instead.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public ConvertDocumentRequest(System.IO.Stream document, string format, string outPath = null, string fileNameFieldValue = null, string storage = null, string fontsLocation = null)
        {
            this.Document = document;
            this.Format = format;
            this.OutPath = outPath;
            this.FileNameFieldValue = fileNameFieldValue;
            this.Storage = storage;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// Converting document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// The format to convert.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// The path to the output document on a local storage.
        /// </summary>
        public string OutPath { get; set; }

        /// <summary>
        /// The filename of the output document, that will be used when the resulting document has a dynamic field {filename}. If it is not set, the "sourceFilename" will be used instead.
        /// </summary>
        public string FileNameFieldValue { get; set; }

        /// <summary>
        /// Original document storage.
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>
        public string FontsLocation { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'document' is set
            if (this.Document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ConvertDocument");
            }

            // verify the required parameter 'format' is set
            if (this.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling ConvertDocument");
            }

            var path = configuration.GetApiRootUrl() + "/words/convert";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddQueryParameterToUrl(path, "format", this.Format);
            path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.OutPath);
            path = UrlHelper.AddQueryParameterToUrl(path, "fileNameFieldValue", this.FileNameFieldValue);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);
            path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            var formData = new Dictionary<string, object>();
            if (this.Document != null)
            {
                formData.Add("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) });
            }

            if (formData.Count > 0)
            {
                result.Content = ApiInvoker.GetMultipartFormData(formData);
            }

            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public object DeserializeResponse(HttpResponseMessage message)
        {
            return message.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        }
    }
}
