// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OAuthTests.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Infrastructure
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.RequestHandlers;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Tests of OAuth2 authentification
    /// </summary>
    [TestFixture]
    public class OAuthTests : BaseTestContext
    {
        /// <summary>
        /// If token is not valid, refresh token should be successfully.        
        /// </summary>
        [Test]
        [Ignore("Ignored because we use local server to test this feature (access token is expired in 1s)")]
        public void IfTokenIsNotValidRefreshTokenShouldBeSuccessfully()
        {
            // Arrange         
            var api = new WordsApi(
                new Configuration
                    {
                        AppKey = this.AppKey,
                        AppSid = this.AppSid,
                        ApiBaseUrl = "http://localhost:8081",
                        AuthType = AuthType.OAuth2,
                        DebugMode = true
                    });

            using (var stream = this.ToStream("content"))
            {
                var request = new ConvertDocumentRequest(stream, "txt");
                api.ConvertDocument(request);

                Thread.Sleep(2000);
                stream.Flush();
                stream.Position = 0;

                var traceListenerMock = new Mock<TraceListener>();
                traceListenerMock.Setup(x => x.WriteLine(It.IsAny<string>())).Verifiable();
                Trace.Listeners.Add(traceListenerMock.Object);
                try
                {
                    // Act
                    api.ConvertDocument(request);

                    // Assert                    
                    traceListenerMock.Verify(x => x.WriteLine(It.Is<string>(s => s.Contains("grant_type=refresh_token"))), Times.Once);
                    traceListenerMock.Verify(x => x.WriteLine(It.IsAny<string>()), Times.AtLeast(2));
                }
                finally
                {
                    Trace.Listeners.Remove(traceListenerMock.Object);
                }
            }
        }

        /// <summary>
        /// Check if appsid is wrong exception is thrown.
        /// </summary>
        [Test]
        public void TestWrongAppSidThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new WordsApi("", ""));

            var configuration = new Configuration
            {
                AppKey = "qqqq",
                AppSid = "tttt",
                ApiBaseUrl = "https://api-qa.aspose.cloud",
                AuthType = AuthType.OAuth2,
                DebugMode = true
            };

            var oauthHandler = new OAuthRequestHandler(configuration);
            Assert.Throws<ApiException>(() => oauthHandler.ProcessUrl("url"));
        }

        /// <summary>
        /// Auth multithread test.
        /// </summary>
        [Test]
        [Ignore("Not yet fixed on platform")]
        public void MultithreadAuth()
        {
            var configuration = new Configuration
                                    {
                                        AppKey = this.AppKey,
                                        AppSid = this.AppSid,
                                        ApiBaseUrl = "http://auckland-words-cloud-staging.dynabic.com",
                                        AuthType = AuthType.OAuth2,
                                        DebugMode = true
                                    };

            var oauthHandler1 = new OAuthRequestHandler(configuration);
            var oauthHandler2 = new OAuthRequestHandler(configuration);
            
            Parallel.Invoke(
                () => oauthHandler1.ProcessUrl("url"),
                () => oauthHandler2.ProcessUrl("url"));            
        }
       
        private Stream ToStream(string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}