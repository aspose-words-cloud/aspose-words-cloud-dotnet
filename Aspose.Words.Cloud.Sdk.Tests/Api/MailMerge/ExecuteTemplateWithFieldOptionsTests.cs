// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExecuteTemplateWithFieldOptionsTests.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to perform template execution.
    /// </summary>
    [TestFixture]
    public class ExecuteTemplateWithFieldOptionsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/MailMerge";
        private readonly string mailMergeFolder = "DocumentActions/MailMerge";

        /// <summary>
        /// Test for posting execute template.
        /// </summary>
        [Test]
        public async Task TestExecuteTemplateWithFieldOptions()
        {
            string localDocumentFile = "TestMailMergeWithOptions.docx";
            string remoteFileName = "TestMailMergeWithOptions.docx";
            string localDataFile = File.ReadAllText(LocalTestDataFolder + mailMergeFolder + "/TestMailMergeData.xml");

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + mailMergeFolder + "/" + localDocumentFile)
            );

            var requestOptionsCurrentUser = new UserInformation()
            {
                Name = "SdkTestUser"
            };
            var requestOptions = new FieldOptions()
            {
                CurrentUser = requestOptionsCurrentUser
            };
            var request = new ExecuteMailMergeRequest(
                name: remoteFileName,
                data: localDataFile,
                options: requestOptions,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.ExecuteMailMerge(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestMailMergeWithOptions.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for execute template online.
        /// </summary>
        [Test]
        public async Task TestExecuteTemplateOnlineWithFieldOptions()
        {
            string localDocumentFile = "TestMailMergeWithOptions.docx";
            string localDataFile = "TestMailMergeData.xml";

            using var requestTemplate = File.OpenRead(LocalTestDataFolder + mailMergeFolder + "/" + localDocumentFile);
            using var requestData = File.OpenRead(LocalTestDataFolder + mailMergeFolder + "/" + localDataFile);
            var requestOptionsCurrentUser = new UserInformation()
            {
                Name = "SdkTestUser"
            };
            var requestOptions = new FieldOptions()
            {
                CurrentUser = requestOptionsCurrentUser
            };
            var request = new ExecuteMailMergeOnlineRequest(
                template: requestTemplate,
                data: requestData,
                options: requestOptions
            );
            var actual = await this.WordsApi.ExecuteMailMergeOnline(request);
        }
    }
}
