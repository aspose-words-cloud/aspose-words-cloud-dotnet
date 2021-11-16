// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OAuthRequestHandler.cs">
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

namespace Aspose.Words.Cloud.Sdk.RequestHandlers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Http;

    using Newtonsoft.Json;

    internal class OAuthRequestHandler : IRequestHandler
    {        
        private readonly Configuration configuration;
        private readonly ApiInvoker apiInvoker;

        private string accessToken;
        private string refreshToken;

        public OAuthRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, configuration.Timeout);
        }

        public void ProcessRequest(HttpRequestMessage request)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.accessToken))
            {
                this.RequestToken();
            }

            if (request.Headers.Contains("Authorization"))
            {
                request.Headers.Remove("Authorization");
            }

            request.Headers.Add("Authorization", "Bearer " + this.accessToken);
        }

        public void ProcessResponse(HttpResponseMessage response)
        {
            if (this.configuration.AuthType != AuthType.OAuth2)
            {
                return;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                this.RequestToken();

                throw new NeedRepeatRequestException();
            }
        }

        private void RequestToken()
        {
            var requestUrl = this.configuration.ApiBaseUrl + "/connect/token";

            var postData = "grant_type=client_credentials";
            postData += "&client_id=" + this.configuration.ClientId;
            postData += "&client_secret=" + this.configuration.ClientSecret;

            var response = this.apiInvoker.InvokeApi(() =>
            {
                var request = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                request.Content = new StringContent(postData, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                return request;
            });
            var result = (GetAccessTokenResult)SerializationHelper.Deserialize(response.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(GetAccessTokenResult));

            this.accessToken = result.AccessToken;
            this.refreshToken = result.RefreshToken;
        }

        private class GetAccessTokenResult
        {
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }

            [JsonProperty(PropertyName = "refresh_token")]
            public string RefreshToken { get; set; }
        }
    }
}
