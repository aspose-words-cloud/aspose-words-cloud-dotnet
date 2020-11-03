// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExecuteMailMergeTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.MailMerge
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to perform mail merge.
    /// </summary>
    [TestFixture]
    public class ExecuteMailMergeTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/MailMerge";
        private readonly string mailMergeFolder = "DocumentActions/MailMerge";

        /// <summary>
        /// Test for executing mail merge online.
        /// </summary>
        [Test]
        public void TestExecuteMailMergeOnline()
        {
            string localDocumentFile = "SampleExecuteTemplate.docx";
            string localDataFile = "SampleExecuteTemplateData.txt";

            var request = new ExecuteMailMergeOnlineRequest(
                template: File.OpenRead(LocalTestDataFolder + mailMergeFolder + "/" + localDocumentFile),
                data: File.OpenRead(LocalTestDataFolder + mailMergeFolder + "/" + localDataFile)
            );

            var actual = this.WordsApi.ExecuteMailMergeOnline(request);
        }

        /// <summary>
        /// Test for executing mail merge.
        /// </summary>
        [Test]
        public void TestExecuteMailMerge()
        {
            string localDocumentFile = "SampleExecuteTemplate.docx";
            string remoteFileName = "TestExecuteMailMerge.docx";
            string localDataFile = File.ReadAllText(LocalTestDataFolder + mailMergeFolder + "/SampleMailMergeTemplateData.txt");

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + mailMergeFolder + "/" + localDocumentFile)
            );

            var request = new ExecuteMailMergeRequest(
                name: remoteFileName,
                data: localDataFile,
                folder: remoteDataFolder,
                withRegions: false,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );

            var actual = this.WordsApi.ExecuteMailMerge(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestExecuteMailMerge.docx", actual.Document.FileName);
        }
    }
}
