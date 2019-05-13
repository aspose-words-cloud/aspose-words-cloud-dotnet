// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ExecuteMailMergeTest.cs">
// //   Copyright (c) 2019 Aspose.Words for Cloud
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

    using NUnit.Framework;

    /// <summary>
    /// Example of how to perform mail merge
    /// </summary>
    [TestFixture]
    public class ExecuteMailMergeTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentActions/MailMerge");

        private readonly string mailMergeFolder = "DocumentActions/MailMerge/";

        /// <summary>
        /// Test for executing mail merge online
        /// </summary>
        [Test]
        public void TestExecuteMailMergeOnlineOnline()
        {
            using (var file = File.OpenRead(BaseTestContext.GetDataDir(this.mailMergeFolder) + "SampleExecuteTemplate.docx"))
            {
                using (var data = File.OpenRead(BaseTestContext.GetDataDir(this.mailMergeFolder) + "SampleExecuteTemplateData.txt"))
                {
                    var request = new ExecuteMailMergeOnlineRequest(file, data);
                    var result = this.WordsApi.ExecuteMailMergeOnline(request);
                    Assert.IsTrue(result.Length > 0, "Error occurred while executing mail merge");
                }
            }
        }

        /// <summary>
        /// Test for executing mail merge
        /// </summary>
        [Test]
        public void TestExecuteMailMerge()
        {
            var localName = "SampleMailMergeTemplate.docx";
            var remoteName = "TestExecuteMailMerge.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var data = File.ReadAllText(BaseTestContext.GetDataDir(this.mailMergeFolder) + "SampleMailMergeTemplateData.txt");

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.mailMergeFolder) + localName));

            var request = new ExecuteMailMergeRequest(remoteName, data, this.dataFolder, destFileName: destFileName, withRegions: false);
            var actual = this.WordsApi.ExecuteMailMerge(request);
        }
    }
}