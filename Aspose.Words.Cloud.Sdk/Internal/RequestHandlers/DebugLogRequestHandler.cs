// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DebugLogRequestHandler.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.RequestHandlers
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Text;

    internal class DebugLogRequestHandler : IRequestHandler
    {
        private readonly Configuration configuration;

        public DebugLogRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public void ProcessRequest(HttpRequestMessage request)
        {
            if (this.configuration.DebugMode)
            {
                this.LogRequest(request);
            }
        }

        public void ProcessResponse(HttpResponseMessage response)
        {
            if (this.configuration.DebugMode)
            {
                this.LogResponse(response);
            }
        }

        private void LogRequest(HttpRequestMessage request)
        {
            var header = string.Format("{0}: {1}", request.Method, request.RequestUri);
            var sb = new StringBuilder();

            this.FormatHeaders(sb, request.Headers);
            if (request.Content != null)
            {
                sb.Append(request.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            }

            this.Log(header, sb);
        }

        private void LogResponse(HttpResponseMessage response)
        {
            var header = string.Format("\r\nResponse {0}: {1}", (int)response.StatusCode, response.StatusCode);
            var sb = new StringBuilder();

            this.FormatHeaders(sb, response.Headers);
            sb.Append(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            this.Log(header, sb);
        }

        private void FormatHeaders(StringBuilder sb, System.Net.Http.Headers.HttpHeaders headerDictionary)
        {
            foreach (var header in headerDictionary)
            {
                sb.Append(header.Key);
                sb.Append(": ");
                sb.AppendLine(string.Join(", ", header.Value));
            }
        }

        private void Log(string header, StringBuilder sb)
        {
            Trace.WriteLine(header);
            Trace.WriteLine(sb.ToString());
            Console.WriteLine(header);
            Console.WriteLine(sb.ToString());
        }
    }
}
