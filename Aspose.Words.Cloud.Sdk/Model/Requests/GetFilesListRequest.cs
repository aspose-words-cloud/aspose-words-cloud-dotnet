// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetFilesListRequest.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFilesList" /> operation.
    /// </summary>
    public class GetFilesListRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesListRequest"/> class.
        /// </summary>
        public GetFilesListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesListRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path e.g. '/folder'.</param>
        /// <param name="storageName">Storage name.</param>
        public GetFilesListRequest(string path, string storageName = null)
        {
            this.Path = path;
            this.StorageName = storageName;
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
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'path' is set
            if (this.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }

            var path = configuration.GetApiRootUrl() + "/words/storage/folder/{path}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "path", this.Path);
            path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.StorageName, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Get, path);
            foreach (var formElement in formData.ToArray())
            {
                if (formElement.Item2 is IModel)
                {
                    var modelElement = (IModel)formElement.Item2;
                    foreach (var fileReference in modelElement.GetFileReferences())
                    {
            			if (fileReference.Source == FileReference.FileSource.Request)
            			{
            				formData.Add(new Tuple<string, object>(fileReference.Document, fileReference));
            			}
                    }
                }
            }

            if (formData.Count == 1)
            {
                result.Content = ApiInvoker.GetBodyParameterData(formData[0].Item2);
            }
            else if (formData.Count > 1)
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
        public async Task<object> DeserializeResponse(HttpResponseMessage message)
        {
            return SerializationHelper.Deserialize(await message.Content.ReadAsStringAsync(), typeof(FilesList));
        }
    }
}
