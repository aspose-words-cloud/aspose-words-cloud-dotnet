// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="InsertHeaderFooterOnlineRequest.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertHeaderFooterOnline" /> operation.
    /// </summary>
    public class InsertHeaderFooterOnlineRequest : IRequestModel, ICanModifyDocumentRequest, ICanSaveRevisionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertHeaderFooterOnlineRequest"/> class.
        /// </summary>
        public InsertHeaderFooterOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertHeaderFooterOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="sectionPath">The path to the section in the document tree.</param>
        /// <param name="headerFooterType">Type of header/footer.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password of protected Word document. Use the parameter to pass a password via SDK. SDK encrypts it automatically. We don't recommend to use the parameter to pass a plain password for direct call of API.</param>
        /// <param name="encryptedPassword">Password of protected Word document. Use the parameter to pass an encrypted password for direct calls of API. See SDK code for encyption details.</param>
        /// <param name="openTypeSupport">The value indicates whether OpenType support is on.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        public InsertHeaderFooterOnlineRequest(System.IO.Stream document, string sectionPath, string headerFooterType, string loadEncoding = null, string password = null, string encryptedPassword = null, bool? openTypeSupport = null, string destFileName = null, string revisionAuthor = null, string revisionDateTime = null)
        {
            this.Document = document;
            this.SectionPath = sectionPath;
            this.HeaderFooterType = headerFooterType;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.EncryptedPassword = encryptedPassword;
            this.OpenTypeSupport = openTypeSupport;
            this.DestFileName = destFileName;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// The path to the section in the document tree.
        /// </summary>
        public string SectionPath { get; set; }

        /// <summary>
        /// Type of header/footer.
        /// </summary>
        public string HeaderFooterType { get; set; }

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
        /// The value indicates whether OpenType support is on.
        /// </summary>
        public bool? OpenTypeSupport { get; set; }

        /// <summary>
        /// Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>
        public string DestFileName { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public async Task<HttpRequestMessage> CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'document' is set
            if (this.Document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling InsertHeaderFooterOnline");
            }

            // verify the required parameter 'sectionPath' is set
            if (this.SectionPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'sectionPath' when calling InsertHeaderFooterOnline");
            }

            // verify the required parameter 'headerFooterType' is set
            if (this.HeaderFooterType == null)
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterType' when calling InsertHeaderFooterOnline");
            }

            var path = configuration.GetApiRootUrl() + "/words/online/put/{sectionPath}/headersfooters";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "sectionPath", this.SectionPath);
            path = await UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "password", this.Password, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "encryptedPassword", this.EncryptedPassword, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "openTypeSupport", this.OpenTypeSupport, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "revisionAuthor", this.RevisionAuthor, encryptor);
            path = await UrlHelper.AddQueryParameterToUrl(path, "revisionDateTime", this.RevisionDateTime, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Put, path);
            if (this.Document != null)
            {
                formData.Add(new Tuple<string, object>("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) }));
            }

            if (this.HeaderFooterType != null)
            {
                formData.Add(new Tuple<string, object>("HeaderFooterType", this.HeaderFooterType));
            }

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
            var multipart = await ApiInvoker.ToMultipartForm(message);
            return new InsertHeaderFooterOnlineResponse(
                model: (HeaderFooterResponse)SerializationHelper.Deserialize(
                    await new StreamReader(multipart["Model"].Content, System.Text.Encoding.UTF8).ReadToEndAsync(),
                    typeof(HeaderFooterResponse)),
                document: await SerializationHelper.DeserializeFilesCollection(multipart["Document"])
            );
        }
    }
}
