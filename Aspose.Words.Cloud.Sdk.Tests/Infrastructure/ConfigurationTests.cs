﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConfigurationTests.cs">
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
    using System.Diagnostics;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Moq;

    using NUnit.Framework;

    /// <summary>
    /// Tests of sdk's configuration
    /// </summary>
    [TestFixture]
    public class ConfigurationTests : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "BaseApiTest");

        /// <summary>
        /// If user set the "Debug" option, request and response should be writed to trace
        /// </summary>
        [Test]
        public void IfUserSetDebugOptionRequestAndErrorsShouldBeWroteToTrace()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "IfUserSetDebugOptionRequestAndErrorsShouldBeWritedToTrace.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var request = new DeleteFieldsRequest(remoteName, null, this.dataFolder);
            var api = new WordsApi(
                new Configuration
                    {
                        ApiBaseUrl = this.BaseProductUri,
                        AppKey = this.AppKey,
                        AppSid = this.AppSid,
                        DebugMode = true
                    });

            this.UploadFileToStorage(
                fullName,
                null,
                null,
                File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var traceListenerMock = new Mock<TraceListener>();
            traceListenerMock.Setup(x => x.WriteLine(It.IsAny<string>())).Verifiable();
            Trace.Listeners.Add(traceListenerMock.Object);

            try
            {
                // Act
                api.DeleteFields(request);

                // Assert
                traceListenerMock.Verify(x => x.WriteLine(It.Is<string>(s => s.Contains("grant_type=client_credentials"))), Times.Once);
                traceListenerMock.Verify(x => x.WriteLine(It.Is<string>(s => s.Contains($"DELETE: {this.BaseProductUri}/v4.0/words/IfUserSetDebugOptionRequestAndErrorsShouldBeWritedToTrace.docx/fields"))), Times.Once);
                traceListenerMock.Verify(x => x.WriteLine(It.Is<string>(s => s.Contains("Response 200: OK"))), Times.Exactly(2));
            }
            finally
            {
                Trace.Listeners.Remove(traceListenerMock.Object);
            }
        }
    }
}