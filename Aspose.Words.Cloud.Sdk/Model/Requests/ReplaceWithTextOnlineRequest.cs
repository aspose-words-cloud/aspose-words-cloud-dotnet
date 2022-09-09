// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReplaceWithTextOnlineRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ReplaceWithTextOnline" /> operation.
    /// </summary>
    public class ReplaceWithTextOnlineRequest : IRequestModel, ICanModifyDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceWithTextOnlineRequest"/> class.
        /// </summary>
        public ReplaceWithTextOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceWithTextOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="rangeStartIdentifier">The range start identifier.</param>
        /// <param name="rangeText">Model with text for replacement.</param>
        /// <param name="rangeEndIdentifier">The range end identifier.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.</param>
        /// <param name="encryptedPassword">Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        public ReplaceWithTextOnlineRequest(System.IO.Stream document, string rangeStartIdentifier, ReplaceRange rangeText, string rangeEndIdentifier = null, string loadEncoding = null, string password = null, string encryptedPassword = null, string destFileName = null)
        {
            this.Document = document;
            this.RangeStartIdentifier = rangeStartIdentifier;
            this.RangeText = rangeText;
            this.RangeEndIdentifier = rangeEndIdentifier;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.EncryptedPassword = encryptedPassword;
            this.DestFileName = destFileName;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// The range start identifier.
        /// </summary>
        public string RangeStartIdentifier { get; set; }

        /// <summary>
        /// Model with text for replacement.
        /// </summary>
        public ReplaceRange RangeText { get; set; }

        /// <summary>
        /// The range end identifier.
        /// </summary>
        public string RangeEndIdentifier { get; set; }

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
        /// Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>
        public string DestFileName { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'document' is set
            if (this.Document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ReplaceWithTextOnline");
            }

            // verify the required parameter 'rangeStartIdentifier' is set
            if (this.RangeStartIdentifier == null)
            {
                throw new ApiException(400, "Missing required parameter 'rangeStartIdentifier' when calling ReplaceWithTextOnline");
            }

            // verify the required parameter 'rangeText' is set
            if (this.RangeText == null)
            {
                throw new ApiException(400, "Missing required parameter 'rangeText' when calling ReplaceWithTextOnline");
            }

            var path = configuration.GetApiRootUrl() + "/words/online/post/range/{rangeStartIdentifier}/{rangeEndIdentifier}";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "rangeStartIdentifier", this.RangeStartIdentifier);
            path = UrlHelper.AddPathParameter(path, "rangeEndIdentifier", this.RangeEndIdentifier);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword", this.EncryptedPassword, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Put, path);
            if (this.Document != null)
            {
                formData.Add(new Tuple<string, object>("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) }));
            }

            if (this.RangeText != null)
            {
                formData.Add(new Tuple<string, object>("RangeText", this.RangeText));
            }

            result.Content = ApiInvoker.GetRequestContent(formData);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public async Task<object> DeserializeResponse(HttpResponseMessage message)
        {
            var multipart = await ApiInvoker.ToMultipartForm(message);
            return new ReplaceWithTextOnlineResponse(
                model: (DocumentResponse)SerializationHelper.Deserialize(
                    await new StreamReader(multipart["Model"].Content, System.Text.Encoding.UTF8).ReadToEndAsync(),
                    typeof(DocumentResponse)),
                document: await SerializationHelper.DeserializeFilesCollection(multipart["Document"])
            );
        }
    }
}
