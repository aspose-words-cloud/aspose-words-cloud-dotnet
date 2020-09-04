// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BuildReportOnlineRequest.cs">
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

namespace Aspose.Words.Cloud.Sdk.Model.Requests
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.BuildReportOnline" /> operation.
    /// </summary>
    public class BuildReportOnlineRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildReportOnlineRequest"/> class.
        /// </summary>
        public BuildReportOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildReportOnlineRequest"/> class.
        /// </summary>
        /// <param name="template">File with template.</param>
        /// <param name="data">A string providing a data to populate the specified template. The string must be of one of the following types: xml, json, csv.</param>
        /// <param name="reportEngineSettings">An object providing a settings of report engine.</param>
        /// <param name="documentFileName">This file name will be used when resulting document has dynamic field for document file name {filename}. If it is not set, "template" will be used instead.</param>
        public BuildReportOnlineRequest(System.IO.Stream template, string data, ReportEngineSettings reportEngineSettings, string documentFileName = null)
        {
            this.Template = template;
            this.Data = data;
            this.ReportEngineSettings = reportEngineSettings;
            this.DocumentFileName = documentFileName;
        }

        /// <summary>
        /// File with template.
        /// </summary>
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// A string providing a data to populate the specified template. The string must be of one of the following types: xml, json, csv.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// An object providing a settings of report engine.
        /// </summary>
        public ReportEngineSettings ReportEngineSettings { get; set; }

        /// <summary>
        /// This file name will be used when resulting document has dynamic field for document file name {filename}. If it is not set, "template" will be used instead.
        /// </summary>
        public string DocumentFileName { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'template' is set
            if (this.Template == null)
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling BuildReportOnline");
            }

            // verify the required parameter 'data' is set
            if (this.Data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling BuildReportOnline");
            }

            // verify the required parameter 'reportEngineSettings' is set
            if (this.ReportEngineSettings == null)
            {
                throw new ApiException(400, "Missing required parameter 'reportEngineSettings' when calling BuildReportOnline");
            }

            var path = configuration.GetApiRootUrl() + "/words/buildReport";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddQueryParameterToUrl(path, "documentFileName", this.DocumentFileName);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            var formData = new Dictionary<string, object>();
            if (this.Template != null)
            {
                formData.Add("template", new FileInfo { Name = "Template", FileContent = StreamHelper.ReadAsBytes(this.Template) });
            }

            if (this.Data != null)
            {
                formData.Add("Data", this.Data);
            }

            if (this.ReportEngineSettings != null)
            {
                formData.Add("ReportEngineSettings", this.ReportEngineSettings);
            }

            if (formData.Count > 0)
            {
                result.Content = ApiInvoker.GetMultipartFormData(formData);
            }

            return result;
        }

        /// <summary>
        /// Returns type of operation response.
        /// </summary>
        /// <returns>Response type.</returns>
        public Type GetResponseType()
        {
            return typeof(System.IO.Stream);
        }
    }
}
