// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFolderRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.CopyFolder" /> operation.
    /// </summary>
    public class CopyFolderRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>
        public CopyFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFolderRequest"/> class.
        /// </summary>
        /// <param name="srcPath">Source folder path e.g. '/src'.</param>
        /// <param name="destPath">Destination folder path e.g. '/dst'.</param>
        /// <param name="srcStorageName">Source storage name.</param>
        /// <param name="destStorageName">Destination storage name.</param>
        public CopyFolderRequest(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)
        {
            this.SrcPath = srcPath;
            this.DestPath = destPath;
            this.SrcStorageName = srcStorageName;
            this.DestStorageName = destStorageName;
        }

        /// <summary>
        /// Source folder path e.g. '/src'.
        /// </summary>
        public string SrcPath { get; set; }

        /// <summary>
        /// Destination folder path e.g. '/dst'.
        /// </summary>
        public string DestPath { get; set; }

        /// <summary>
        /// Source storage name.
        /// </summary>
        public string SrcStorageName { get; set; }

        /// <summary>
        /// Destination storage name.
        /// </summary>
        public string DestStorageName { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            var path = configuration.GetApiRootUrl() + "/words/storage/folder/copy/{srcPath}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "srcPath", this.SrcPath);
            path = UrlHelper.AddQueryParameterToUrl(path, "destPath", this.DestPath);
            path = UrlHelper.AddQueryParameterToUrl(path, "srcStorageName", this.SrcStorageName);
            path = UrlHelper.AddQueryParameterToUrl(path, "destStorageName", this.DestStorageName);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
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
