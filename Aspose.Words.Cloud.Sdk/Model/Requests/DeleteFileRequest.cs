// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteFileRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFile" /> operation.
    /// </summary>
    public class DeleteFileRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileRequest"/> class.
        /// </summary>
        public DeleteFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileRequest"/> class.
        /// </summary>
        /// <param name="path">File path e.g. '/folder/file.ext'.</param>
        /// <param name="storageName">Storage name.</param>
        /// <param name="versionId">File version ID to delete.</param>
        public DeleteFileRequest(string path, string storageName = null, string versionId = null)
        {
            this.Path = path;
            this.StorageName = storageName;
            this.VersionId = versionId;
        }

        /// <summary>
        /// File path e.g. '/folder/file.ext'.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string StorageName { get; set; }

        /// <summary>
        /// File version ID to delete.
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'path' is set
            if (this.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }

            var path = configuration.GetApiRootUrl() + "/words/storage/file/{path}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "path", this.Path);
            path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.StorageName);
            path = UrlHelper.AddQueryParameterToUrl(path, "versionId", this.VersionId);

            var result = new HttpRequestMessage(HttpMethod.Delete, path);
            return result;
        }

        /// <summary>
        /// Returns type of operation response.
        /// </summary>
        /// <returns>Response type.</returns>
        public Type GetResponseType()
        {
            return null;
        }
    }
}
