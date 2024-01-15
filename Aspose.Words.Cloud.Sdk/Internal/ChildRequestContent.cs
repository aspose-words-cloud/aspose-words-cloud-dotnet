// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChildRequestContent.cs">
//   Copyright (c) 2024 Aspose.Words for Cloud
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
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.WebUtilities;

    /// <summary>
    /// Represents child request content.
    /// </summary>
    internal class ChildRequestContent : HttpContent
    {
        private static readonly char[] Crlf = "\r\n".ToCharArray();
        private readonly HttpRequestMessage message;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildRequestContent"/> class.
        /// </summary>
        /// <param name="configuration">See <see cref="Configuration"/>.</param>
        /// <param name="message">See <see cref="HttpRequestMessage"/>.</param>
        public ChildRequestContent(Configuration configuration, HttpRequestMessage message)
        {
            this.message = message;
            this.Headers.ContentType = new MediaTypeHeaderValue("application/http");
            this.Headers.ContentType.Parameters.Add(new NameValueHeaderValue("msgtype", "request"));

            var uriStart = new System.Uri(configuration.GetApiRootUrl() + "/words/");
            this.message.RequestUri = uriStart.MakeRelativeUri(this.message.RequestUri);
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.message.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <inheritdoc />
        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            using (var sb = new HttpResponseStreamWriter(stream, Encoding.UTF8))
            {
                await sb.WriteAsync(this.message.Method.Method).ConfigureAwait(false);
                await sb.WriteAsync(' ').ConfigureAwait(false);
                await sb.WriteAsync(this.message.RequestUri.ToString()).ConfigureAwait(false);
                await sb.WriteAsync(' ').ConfigureAwait(false);
                await sb.WriteAsync(Crlf).ConfigureAwait(false);
                foreach (var header in this.message.Headers)
                {
                    await sb.WriteAsync(header.Key).ConfigureAwait(false);
                    await sb.WriteAsync(": ").ConfigureAwait(false);
                    await sb.WriteAsync(string.Join(", ", header.Value)).ConfigureAwait(false);
                    await sb.WriteAsync(Crlf).ConfigureAwait(false);
                }

                if (this.message.Content?.Headers != null)
                {
                    foreach (var header in this.message.Content?.Headers)
                    {
                        await sb.WriteAsync(header.Key).ConfigureAwait(false);
                        await sb.WriteAsync(": ").ConfigureAwait(false);
                        await sb.WriteAsync(string.Join(", ", header.Value)).ConfigureAwait(false);
                        await sb.WriteAsync(Crlf).ConfigureAwait(false);
                    }
                }

                await sb.WriteAsync(Crlf).ConfigureAwait(false);
            }

            if (this.message.Content != null)
            {
                using (var contentStream = await this.message.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    await contentStream.CopyToAsync(stream).ConfigureAwait(false);
                }
            }
        }

        /// <inheritdoc />
        protected override bool TryComputeLength(out long length)
        {
            length = 0;
            return false;
        }
    }
}
