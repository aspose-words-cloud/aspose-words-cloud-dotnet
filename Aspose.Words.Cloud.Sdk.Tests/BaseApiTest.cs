// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseApiTest.cs">
//   Copyright (c) 2017 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests
{
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Aspose.Words.Cloud.Sdk;    
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NMock;

    /// <summary>
    /// This is a test class for TestWordsApi and is intended
    /// to contain all TestWordsApi Unit Tests
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class BaseApiTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "BaseApiTest");

        /// <summary>
        /// If file does not exist, 400 response should be returned with message "Error while loading file ".
        /// </summary>
        [TestMethod]
        public void TestHandleErrors()
        {
            string name = "noFileWithThisName.docx";
            
            try
            {
                var request = new GetSectionsRequest(name);
                this.WordsApi.GetSections(request);

                Assert.Fail("Expected exception has not been thrown");
            }
            catch (ApiException apiException)
            {
                Assert.AreEqual(400, apiException.ErrorCode);
                Assert.IsTrue(apiException.Message.StartsWith("Error while loading file 'noFileWithThisName.docx' from storage:"), "Current message: " + apiException.Message);
            }
        }

        /// <summary>
        /// If user set the "Debug" option, request and response should be writed to trace
        /// </summary>
        [TestMethod]
        public void IfUserSetDebugOptionRequestAndErrorsShouldBeWritedToTrace()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "IfUserSetDebugOptionRequestAndErrorsShouldBeWritedToTrace.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var request = new DeleteFieldsRequest(remoteName, this.dataFolder);
            var api = new WordsApi(new Configuration { ApiBaseUrl = BaseProductUri, AppKey = this.AppKey, AppSid = this.AppSid, DebugMode = true });

            var mockFactory = new MockFactory();
            var traceListenerMock = mockFactory.CreateMock<TraceListener>();
            Trace.Listeners.Add(traceListenerMock.MockObject);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty)).With(Is.StringContaining("DELETE: http://api-dev.aspose.cloud/v1.1/words/IfUserSetDebugOptionRequestAndErrorsShouldBeWritedToTrace.docx/fields"));
            traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty)).With(Is.StringContaining("Response 200: OK"));
            traceListenerMock.Expects.One.Method(p => p.WriteLine(string.Empty)).With(Is.StringContaining("{\"Code\":200,\"Status\":\"OK\"}"));

            traceListenerMock.Expects.AtLeastOne.Method(p => p.WriteLine(string.Empty)).With(Is.Anything);

            // Act
            api.DeleteFields(request);
            
            // Assert                    
            mockFactory.VerifyAllExpectationsHaveBeenMet();
        }

        /// <summary>
        /// Check if all API methods have covered by tests
        /// </summary>
        [TestMethod]
        public void TestApiCoverage()
        {
            var methods = typeof(WordsApi).GetMethods()
                .Where(p => p.IsPublic && p.DeclaringType != typeof(object))
                .Select(p => p.Name)
                .ToList();
            var unitTestFolder = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Aspose.Words.Cloud.Sdk.Tests");
            var bddTestFolder = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Aspose.Words.Cloud.Sdk.BddTests");
            var unitTestFiles = DirectoryHelper.GetFilesByExtension(unitTestFolder, ".cs", SearchOption.AllDirectories).ToList();
            var bddTestFiles = DirectoryHelper.GetFilesByExtension(bddTestFolder, ".cs", SearchOption.AllDirectories).ToList();
            unitTestFiles.AddRange(bddTestFiles);
            var filesContent = unitTestFiles.Select(File.ReadAllText).ToList();
            var strBuilder = new StringBuilder();
            foreach (var methodInfo in methods)
            {
                if (filesContent.All(p => !p.Contains(methodInfo)))
                {
                    strBuilder.AppendFormat("Uncovered api method {0}\n", methodInfo);
                }
            }

            Assert.IsTrue(strBuilder.Length == 0, strBuilder.ToString());
        }
    }
}
