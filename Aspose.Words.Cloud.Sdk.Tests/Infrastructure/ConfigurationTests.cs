// --------------------------------------------------------------------------------------------------------------------
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

    using NMock;

    using NUnit.Framework;

    using Is = NMock.Is;

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
            var request = new DeleteFieldsRequest(remoteName, this.dataFolder);
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

            var mockFactory = new MockFactory();
            var traceListenerMock = mockFactory.CreateMock<TraceListener>();
            Trace.Listeners.Add(traceListenerMock.MockObject);

            try
            {
                traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty)).With(
                    Is.StringContaining(
                        $"DELETE: {this.BaseProductUri}/v3/words/IfUserSetDebugOptionRequestAndErrorsShouldBeWritedToTrace.docx/fields"));
                traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty))
                    .With(Is.StringContaining("Response 200: OK"));
               
                traceListenerMock.Expects.AtLeastOne.Method(p => p.WriteLine(string.Empty)).With(Is.Anything);

                // Act
                api.DeleteFields(request);

                // Assert                    
                mockFactory.VerifyAllExpectationsHaveBeenMet();
            }
            finally
            {
                Trace.Listeners.Remove(traceListenerMock.MockObject);
            }
        }
    }
}