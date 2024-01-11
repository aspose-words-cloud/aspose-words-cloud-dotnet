// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentProtectionTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.DocumentProtection
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to set document protection.
    /// </summary>
    [TestFixture]
    public class DocumentProtectionTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/DocumentProtection";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for setting document protection.
        /// </summary>
        [Test]
        public async Task TestProtectDocument()
        {
            string remoteFileName = "TestProtectDocument.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestProtectionRequest = new ProtectionRequestV2()
            {
                ProtectionPassword = "123",
                ProtectionType = ProtectionRequestV2.ProtectionTypeEnum.ReadOnly
            };
            var request = new ProtectDocumentRequest(
                name: remoteFileName,
                protectionRequest: requestProtectionRequest,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.ProtectDocument(request);
            Assert.NotNull(actual.ProtectionData);

        }

        /// <summary>
        /// Test for setting document protection.
        /// </summary>
        [Test]
        public async Task TestProtectDocumentOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestProtectionRequest = new ProtectionRequestV2()
            {
                ProtectionPassword = "123",
                ProtectionType = ProtectionRequestV2.ProtectionTypeEnum.ReadOnly
            };
            var request = new ProtectDocumentOnlineRequest(
                document: requestDocument,
                protectionRequest: requestProtectionRequest
            );
            var actual = await this.WordsApi.ProtectDocumentOnline(request);
        }

        /// <summary>
        /// Test for getting document protection.
        /// </summary>
        [Test]
        public async Task TestGetDocumentProtection()
        {
            string localFilePath = "DocumentActions/DocumentProtection/SampleProtectedBlankWordDocument.docx";
            string remoteFileName = "TestGetDocumentProtection.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFilePath)
            );

            var request = new GetDocumentProtectionRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentProtection(request);
        }

        /// <summary>
        /// Test for getting document protection.
        /// </summary>
        [Test]
        public async Task TestGetDocumentProtectionOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentProtectionOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetDocumentProtectionOnline(request);
        }

        /// <summary>
        /// Test for deleting unprotect document.
        /// </summary>
        [Test]
        public async Task TestDeleteUnprotectDocument()
        {
            string localFilePath = "DocumentActions/DocumentProtection/SampleProtectedBlankWordDocument.docx";
            string remoteFileName = "TestDeleteUnprotectDocument.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFilePath)
            );

            var request = new UnprotectDocumentRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UnprotectDocument(request);
            Assert.NotNull(actual.ProtectionData);

        }

        /// <summary>
        /// Test for deleting unprotect document.
        /// </summary>
        [Test]
        public async Task TestDeleteUnprotectDocumentOnline()
        {
            string localFilePath = "DocumentActions/DocumentProtection/SampleProtectedBlankWordDocument.docx";

            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFilePath);
            var request = new UnprotectDocumentOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.UnprotectDocumentOnline(request);
        }
    }
}
