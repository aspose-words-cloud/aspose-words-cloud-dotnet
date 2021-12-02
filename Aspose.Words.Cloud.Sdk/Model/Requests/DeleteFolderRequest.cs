// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteFolderRequest.cs">
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
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Responses;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFolder" /> operation.
    /// </summary>
    public class DeleteFolderRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
        /// </summary>
        public DeleteFolderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path e.g. '/folder'.</param>
        /// <param name="storageName">Storage name.</param>
        /// <param name="recursive">Enable to delete folders, subfolders and files.</param>
        public DeleteFolderRequest(string path, string storageName = null, bool? recursive = null)
        {
            this.Path = path;
            this.StorageName = storageName;
            this.Recursive = recursive;
        }

        /// <summary>
        /// Folder path e.g. '/folder'.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Storage name.
        /// </summary>
        public string StorageName { get; set; }

        /// <summary>
        /// Enable to delete folders, subfolders and files.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration, RSA encryptor)
        {
            // verify the required parameter 'path' is set
            if (this.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }

            var path = configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "path", this.Path);
            path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.StorageName, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "recursive", this.Recursive, encryptor);

            var result = new HttpRequestMessage(HttpMethod.Delete, path);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public async Task<object> DeserializeResponse(HttpResponseMessage message)
        {
            return null;
        }
    }
}
