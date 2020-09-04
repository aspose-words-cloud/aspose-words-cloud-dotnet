// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetHeaderFootersRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooters" /> operation.
    /// </summary>
    public class GetHeaderFootersRequest : IRequestModel, IWordDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFootersRequest"/> class.
        /// </summary>
        public GetHeaderFootersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFootersRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="sectionPath">Path to parent section.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="filterByType">List of types of headers and footers.</param>
        public GetHeaderFootersRequest(string name, string sectionPath, string folder = null, string storage = null, string loadEncoding = null, string password = null, string filterByType = null)
        {
            this.Name = name;
            this.SectionPath = sectionPath;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FilterByType = filterByType;
        }

        /// <summary>
        /// The document name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>
        public string SectionPath { get; set; }

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
        /// List of types of headers and footers.
        /// </summary>
        public string FilterByType { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'name' is set
            if (this.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooters");
            }

            var path = configuration.GetApiRootUrl() + "/words/{name}/{sectionPath}/headersfooters";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "name", this.Name);
            path = UrlHelper.AddPathParameter(path, "sectionPath", this.SectionPath);
            path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "filterByType", this.FilterByType);

            var result = new HttpRequestMessage(HttpMethod.Get, path);
            return result;
        }

        /// <summary>
        /// Returns type of operation response.
        /// </summary>
        /// <returns>Response type.</returns>
        public Type GetResponseType()
        {
            return typeof(HeaderFootersResponse);
        }
    }
}
