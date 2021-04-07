// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsOnlineRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.SaveAsOnline" /> operation.
    /// </summary>
    public class SaveAsOnlineRequest : IRequestModel, ICanUseCustomFontsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsOnlineRequest"/> class.
        /// </summary>
        public SaveAsOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="saveOptionsData">Save options.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public SaveAsOnlineRequest(System.IO.Stream document, SaveOptionsData saveOptionsData, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            this.Document = document;
            this.SaveOptionsData = saveOptionsData;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Save options.
        /// </summary>
        public SaveOptionsData SaveOptionsData { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>
        public string FontsLocation { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'document' is set
            if (this.Document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SaveAsOnline");
            }

            // verify the required parameter 'saveOptionsData' is set
            if (this.SaveOptionsData == null)
            {
                throw new ApiException(400, "Missing required parameter 'saveOptionsData' when calling SaveAsOnline");
            }

            var path = configuration.GetApiRootUrl() + "/words/online/put/saveAs";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            var formData = new Dictionary<string, object>();
            if (this.Document != null)
            {
                formData.Add("document", new Aspose.Words.Cloud.Sdk.FileInfo() { Name = "Document", FileContent = StreamHelper.ReadAsBytes(this.Document) });
            }

            if (this.SaveOptionsData != null)
            {
                formData.Add("SaveOptionsData", this.SaveOptionsData);
            }

            if (formData.Count > 0)
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
        public object DeserializeResponse(HttpResponseMessage message)
        {
            var multipart = ApiInvoker.ToMultipartForm(message);
            return new SaveAsOnlineResponse(
                model: (SaveResponse)SerializationHelper.Deserialize(
                    new StreamReader(multipart["Model"], System.Text.Encoding.UTF8).ReadToEnd(),
                    typeof(SaveResponse)),
                document: multipart["Document"]
            );
        }
    }
}
