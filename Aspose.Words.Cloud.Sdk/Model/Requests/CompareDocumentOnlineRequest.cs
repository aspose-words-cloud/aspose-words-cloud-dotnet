// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompareDocumentOnlineRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.CompareDocumentOnline" /> operation.
    /// </summary>
    public class CompareDocumentOnlineRequest : IRequestModel, ICanModifyDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareDocumentOnlineRequest"/> class.
        /// </summary>
        public CompareDocumentOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompareDocumentOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="compareData">Compare data.</param>
        /// <param name="comparingDocument">The comparing document.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.</param>
        /// <param name="encryptedPassword">Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="encryptedPassword2">encrypted password for the second document.</param>
        public CompareDocumentOnlineRequest(System.IO.Stream document, CompareData compareData, System.IO.Stream comparingDocument = null, string loadEncoding = null, string password = null, string encryptedPassword = null, string destFileName = null, string encryptedPassword2 = null)
        {
            this.Document = document;
            this.CompareData = compareData;
            this.ComparingDocument = comparingDocument;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.EncryptedPassword = encryptedPassword;
            this.DestFileName = destFileName;
            this.EncryptedPassword2 = encryptedPassword2;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Compare data.
        /// </summary>
        public CompareData CompareData { get; set; }

        /// <summary>
        /// The comparing document.
        /// </summary>
        public System.IO.Stream ComparingDocument { get; set; }

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
        /// encrypted password for the second document.
        /// </summary>
        public string EncryptedPassword2 { get; set; }

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
                throw new ApiException(400, "Missing required parameter 'document' when calling CompareDocumentOnline");
            }

            // verify the required parameter 'compareData' is set
            if (this.CompareData == null)
            {
                throw new ApiException(400, "Missing required parameter 'compareData' when calling CompareDocumentOnline");
            }

            this.CompareData?.Validate();

            var path = configuration.GetApiRootUrl() + "/words/online/put/compareDocument";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword", this.EncryptedPassword, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName, encryptor);
            path = UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword2", this.EncryptedPassword2, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Put, path);
            if (this.Document != null)
            {
                formData.Add(new Tuple<string, object>("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) }));
            }

            if (this.CompareData != null)
            {
                formData.Add(new Tuple<string, object>("CompareData", this.CompareData));
            }

            if (this.ComparingDocument != null)
            {
                formData.Add(new Tuple<string, object>("comparingDocument", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "ComparingDocument", FileContent = StreamHelper.ReadAsBytes(this.ComparingDocument) }));
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
            return new CompareDocumentOnlineResponse(
                model: (DocumentResponse)SerializationHelper.Deserialize(
                    await new StreamReader(multipart["Model"].Content, System.Text.Encoding.UTF8).ReadToEndAsync(),
                    typeof(DocumentResponse)),
                document: await SerializationHelper.DeserializeFilesCollection(multipart["Document"])
            );
        }
    }
}
