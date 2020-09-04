// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClassifyDocumentRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ClassifyDocument" /> operation.
    /// </summary>
    public class ClassifyDocumentRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyDocumentRequest"/> class.
        /// </summary>
        public ClassifyDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyDocumentRequest"/> class.
        /// </summary>
        /// <param name="documentName">The document name.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="bestClassesCount">Count of the best classes to return.</param>
        /// <param name="taxonomy">Taxonomy to use for classification return.</param>
        public ClassifyDocumentRequest(string documentName, string folder = null, string storage = null, string loadEncoding = null, string password = null, string bestClassesCount = null, string taxonomy = null)
        {
            this.DocumentName = documentName;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.BestClassesCount = bestClassesCount;
            this.Taxonomy = taxonomy;
        }

        /// <summary>
        /// The document name.
        /// </summary>
        public string DocumentName { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Original document storage.
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Count of the best classes to return.
        /// </summary>
        public string BestClassesCount { get; set; }

        /// <summary>
        /// Taxonomy to use for classification return.
        /// </summary>
        public string Taxonomy { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'documentName' is set
            if (this.DocumentName == null)
            {
                throw new ApiException(400, "Missing required parameter 'documentName' when calling ClassifyDocument");
            }

            var path = configuration.GetApiRootUrl() + "/words/{documentName}/classify";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "documentName", this.DocumentName);
            path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "bestClassesCount", this.BestClassesCount);
            path = UrlHelper.AddQueryParameterToUrl(path, "taxonomy", this.Taxonomy);

            var result = new HttpRequestMessage(HttpMethod.Get, path);
            return result;
        }

        /// <summary>
        /// Returns type of operation response.
        /// </summary>
        /// <returns>Response type.</returns>
        public Type GetResponseType()
        {
            return typeof(ClassificationResponse);
        }
    }
}
