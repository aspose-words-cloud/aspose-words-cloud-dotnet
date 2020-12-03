// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Configuration.cs">
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

namespace Aspose.Words.Cloud.Sdk
{
    using System;

    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        private string apiBaseUrl = "https://api.aspose.cloud";
        private bool debugMode = false;

        /// <summary>
        /// Aspose.Words for Cloud API base URL.
        /// </summary>
        public string ApiBaseUrl
        {
            get
            {
                return this.apiBaseUrl;
            }

            set
            {
                var urlValue = value ?? this.apiBaseUrl;

                Uri result;
                if (!Uri.TryCreate(urlValue, UriKind.Absolute, out result) || 
                    !(result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps))
                {
                    throw new ArgumentException("ApiBaseUrl is not valid HTTP / HTTPS URL");
                }

                this.apiBaseUrl = urlValue;
            }
        }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether debug mode.
        /// </summary>
        public bool DebugMode
        {
            get
            {
                return this.debugMode;
            }

            set
            {
                this.debugMode = value;
            }
        }

        /// <summary>
        /// Authentication type.
        /// Default is OAuth 2.0
        /// </summary>
        public AuthType AuthType { get; set; }

        internal string GetApiRootUrl()
        {
            var result = this.ApiBaseUrl + "/v4.0";

            return result.EndsWith("/") ? result.Substring(0, result.Length - 1) : result;
        }       
    }
}
