// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetDocumentFieldNamesOnlineRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentFieldNamesOnline" /> operation.
    /// </summary>
    public class GetDocumentFieldNamesOnlineRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentFieldNamesOnlineRequest"/> class.
        /// </summary>
        public GetDocumentFieldNamesOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentFieldNamesOnlineRequest"/> class.
        /// </summary>
        /// <param name="template">File with template.</param>
        /// <param name="useNonMergeFields">The flag indicating whether to use non merge fields. If true, result includes "mustache" field names.</param>
        public GetDocumentFieldNamesOnlineRequest(System.IO.Stream template, bool? useNonMergeFields = null)
        {
            this.Template = template;
            this.UseNonMergeFields = useNonMergeFields;
        }

        /// <summary>
        /// File with template.
        /// </summary>
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// The flag indicating whether to use non merge fields. If true, result includes "mustache" field names.
        /// </summary>
        public bool? UseNonMergeFields { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'template' when calling GetDocumentFieldNamesOnline");
            }

            var path = configuration.GetApiRootUrl() + "/words/mailMerge/FieldNames";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddQueryParameterToUrl(path, "useNonMergeFields", this.UseNonMergeFields);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            var formData = new Dictionary<string, object>();
            if (this.Template != null)
            {
                formData.Add("template", new FileInfo { Name = "Template", FileContent = StreamHelper.ReadAsBytes(this.Template) });
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
            return typeof(FieldNamesResponse);
        }
    }
}
