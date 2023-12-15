// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClassifyRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.Classify" /> operation.
    /// </summary>
    public class ClassifyRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyRequest"/> class.
        /// </summary>
        public ClassifyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyRequest"/> class.
        /// </summary>
        /// <param name="text">The text to classify.</param>
        /// <param name="bestClassesCount">The number of the best classes to return.</param>
        public ClassifyRequest(string text, string bestClassesCount = null)
        {
            this.Text = text;
            this.BestClassesCount = bestClassesCount;
        }

        /// <summary>
        /// The text to classify.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The number of the best classes to return.
        /// </summary>
        public string BestClassesCount { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <param name="encryptor">password encyptor.</param>
        /// <returns>The http request instance.</returns>
        public async Task<HttpRequestMessage> CreateHttpRequest(Configuration configuration, IEncryptor encryptor)
        {
            // verify the required parameter 'text' is set
            if (this.Text == null)
            {
                throw new ApiException(400, "Missing required parameter 'text' when calling Classify");
            }

            var path = configuration.GetApiRootUrl() + "/words/classify";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = await UrlHelper.AddQueryParameterToUrl(path, "bestClassesCount", this.BestClassesCount, encryptor);

            var formData = new List< Tuple<string, object> >();
            var result = new HttpRequestMessage(HttpMethod.Put, path);
            if (this.Text != null)
            {
                formData.Add(new Tuple<string, object>("Text", this.Text));
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
            return SerializationHelper.Deserialize(await message.Content.ReadAsStringAsync(), typeof(ClassificationResponse));
        }
    }
}
