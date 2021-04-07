// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFileRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.CopyFile" /> operation.
    /// </summary>
    public class CopyFileRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>
        public CopyFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>
        /// <param name="destPath">Destination file path.</param>
        /// <param name="srcPath">Source file's path e.g. '/Folder 1/file.ext' or '/Bucket/Folder 1/file.ext'.</param>
        /// <param name="srcStorageName">Source storage name.</param>
        /// <param name="destStorageName">Destination storage name.</param>
        /// <param name="versionId">File version ID to copy.</param>
        public CopyFileRequest(string destPath, string srcPath, string srcStorageName = null, string destStorageName = null, string versionId = null)
        {
            this.DestPath = destPath;
            this.SrcPath = srcPath;
            this.SrcStorageName = srcStorageName;
            this.DestStorageName = destStorageName;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Destination file path.
        /// </summary>
        public string DestPath { get; set; }

        /// <summary>
        /// Source file's path e.g. '/Folder 1/file.ext' or '/Bucket/Folder 1/file.ext'.
        /// </summary>
        public string SrcPath { get; set; }

        /// <summary>
        /// Source storage name.
        /// </summary>
        public string SrcStorageName { get; set; }

        /// <summary>
        /// Destination storage name.
        /// </summary>
        public string DestStorageName { get; set; }

        /// <summary>
        /// File version ID to copy.
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'srcPath' is set
            if (this.SrcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            var path = configuration.GetApiRootUrl() + "/words/storage/file/copy/{srcPath}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "srcPath", this.SrcPath);
            path = UrlHelper.AddQueryParameterToUrl(path, "destPath", this.DestPath);
            path = UrlHelper.AddQueryParameterToUrl(path, "srcStorageName", this.SrcStorageName);
            path = UrlHelper.AddQueryParameterToUrl(path, "destStorageName", this.DestStorageName);
            path = UrlHelper.AddQueryParameterToUrl(path, "versionId", this.VersionId);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public object DeserializeResponse(HttpResponseMessage message)
        {
            return null;
        }
    }
}
