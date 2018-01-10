// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AuthWithSignatureRequestHandler.cs">
//   Copyright (c) 2016 Aspose.Words for Cloud
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
    using System;
    using System.IO;
    using System.Net;    
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    internal class AuthWithSignatureRequestHandler : IRequestHandler
    {
        private readonly Configuration configuration;

        public AuthWithSignatureRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public string ProcessUrl(string url)
        {
            if (this.configuration.AuthType != AuthType.RequestSignature)
            {
                return url;
            }

            url = UrlHelper.AddQueryParameterToUrl(url, "appSid", this.configuration.AppSid);                      
            url = this.Sign(url);

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
        }

        private string Sign(string url)
        {
            UriBuilder uriBuilder = new UriBuilder(url);
            
            // Remove final slash here as it can be added automatically.
            uriBuilder.Path = uriBuilder.Path.TrimEnd('/');

            // Compute the hash.
            byte[] privateKey = Encoding.UTF8.GetBytes(this.configuration.AppKey);
            HMACSHA1 algorithm = new HMACSHA1(privateKey);

            byte[] sequence = Encoding.ASCII.GetBytes(uriBuilder.Uri.AbsoluteUri);
            byte[] hash = algorithm.ComputeHash(sequence);
            string signature = Convert.ToBase64String(hash);

            // Remove invalid symbols.
            signature = signature.TrimEnd('=');
            signature = HttpUtility.UrlEncode(signature);

            // Convert codes to upper case as they can be updated automatically.
            signature = Regex.Replace(signature, "%[0-9a-f]{2}", e => e.Value.ToUpper());

            // Add the signature to query string.
            return string.Format("{0}&signature={1}", uriBuilder.Uri.AbsoluteUri, signature);
        }
    }
}