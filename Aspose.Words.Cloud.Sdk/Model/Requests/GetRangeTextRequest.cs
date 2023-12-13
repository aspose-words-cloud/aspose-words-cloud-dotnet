// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetRangeTextRequest.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetRangeText" /> operation.
    /// </summary>
    public class GetRangeTextRequest : IRequestModel, IWordDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRangeTextRequest"/> class.
        /// </summary>
        public GetRangeTextRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRangeTextRequest"/> class.
        /// </summary>
        /// <param name="name">The filename of the input document.</param>
        /// <param name="rangeStartIdentifier">The range start identifier. Identifier examples: id0.0.0, page0.</param>
        /// <param name="rangeEndIdentifier">The range end identifier. Identifier examples: id1.0.0, id0.0.0:end, page1, page1:end, document:end.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.</param>
        /// <param name="encryptedPassword">Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.</param>
        public GetRangeTextRequest(string name, string rangeStartIdentifier, string rangeEndIdentifier = null, string folder = null, string storage = null, string loadEncoding = null, string password = null, string encryptedPassword = null)
        {
            this.Name = name;
            this.RangeStartIdentifier = rangeStartIdentifier;
            this.RangeEndIdentifier = rangeEndIdentifier;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.EncryptedPassword = encryptedPassword;
        }

        /// <summary>
        /// The filename of the input document.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The range start identifier. Identifier examples: id0.0.0, page0.
        /// </summary>
        public string RangeStartIdentifier { get; set; }

        /// <summary>
        /// The range end identifier. Identifier examples: id1.0.0, id0.0.0:end, page1, page1:end, document:end.
        /// </summary>
        public string RangeEndIdentifier { get; set; }

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
        /// Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.
        /// </summary>
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public async Task<HttpRequestMessage> CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'name' is set
            if (this.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetRangeText");
            }

            // verify the required parameter 'rangeStartIdentifier' is set
            if (this.RangeStartIdentifier == null)
            {
                throw new ApiException(400, "Missing required parameter 'rangeStartIdentifier' when calling GetRangeText");
            }

            var path = configuration.GetApiRootUrl() + "/words/{name}/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "name", this.Name);
            path = UrlHelper.AddPathParameter(path, "rangeStartIdentifier", this.RangeStartIdentifier);
            path = UrlHelper.AddPathParameter(path, "rangeEndIdentifier", this.RangeEndIdentifier);
            path = await UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "password", this.Password, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword", this.EncryptedPassword, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Get, path);
            result.Content = await ApiInvoker.GetRequestContent(formData, encryptor);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public async Task<object> DeserializeResponse(HttpResponseMessage message)
        {
            return SerializationHelper.Deserialize(await message.Content.ReadAsStringAsync(), typeof(RangeTextResponse));
        }
    }
}
