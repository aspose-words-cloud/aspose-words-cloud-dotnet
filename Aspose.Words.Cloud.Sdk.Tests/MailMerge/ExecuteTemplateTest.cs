// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ExecuteTemplateTest.cs">
// //   Copyright (c) 2017 Aspose.Words for Cloud
// // </copyright>
// // <summary>
// //   Permission is hereby granted, free of charge, to any person obtaining a copy
// //  of this software and associated documentation files (the "Software"), to deal
// //  in the Software without restriction, including without limitation the rights
// //  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// //  copies of the Software, and to permit persons to whom the Software is
// //  furnished to do so, subject to the following conditions:
// // 
// //  The above copyright notice and this permission notice shall be included in all
// //  copies or substantial portions of the Software.
// // 
// //  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// //  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// //  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// //  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// //  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// //  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// //  SOFTWARE.
// // </summary>
// //  --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Words.Cloud.Sdk.Tests.MailMerge
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to perfom template execution
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class ExecuteTemplateTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentActions/MailMerge");

        private readonly string mailMergeFolder = "MailMerge/";

        /// <summary>
        /// Test for posting execute template
        /// </summary>
        [TestMethod]
        public void TestPostExecuteTemplate()
        {
            var localName = "TestExecuteTemplate.doc";
            var remoteName = "TestPostExecuteTemplate.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            var data = File.ReadAllText(BaseTestContext.GetDataDir(this.mailMergeFolder) + "TestExecuteTemplateData.txt");

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.mailMergeFolder) + localName));

            var request = new PostExecuteTemplateRequest(remoteName, data, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.PostExecuteTemplate(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for putting execute template
        /// </summary>
        [TestMethod]
        public void TestPutExecuteTemplateOnline()
        {
            using (var file = File.OpenRead(BaseTestContext.GetDataDir(this.mailMergeFolder) + "SampleMailMergeTemplate.docx"))
            {
                using (var data = File.OpenRead(BaseTestContext.GetDataDir(this.mailMergeFolder) + "SampleExecuteTemplateData.txt"))
                {
                    var request = new PutExecuteTemplateOnlineRequest(file, data);
                    var result = this.WordsApi.PutExecuteTemplateOnline(request);
                    Assert.IsTrue(result.Length > 0, "Error occurred while executing template");
                }
            }
        }
    }
}