// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentProtectionTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.DocumentProtection
{
    using System.Collections.Generic;
    using System.IO;
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
        public void TestProtectDocument()
        {
            string remoteFileName = "TestProtectDocument.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new ProtectDocumentRequest(
                name: remoteFileName,
                protectionRequest: new ProtectionRequest()
                {
                    NewPassword = "123"
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );

            var actual = this.WordsApi.ProtectDocument(request);
        }

        /// <summary>
        /// Test for getting document protection.
        /// </summary>
        [Test]
        public void TestGetDocumentProtection()
        {
            string remoteFileName = "TestGetDocumentProtection.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentProtectionRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentProtection(request);
        }

        /// <summary>
        /// Test for changing document protection.
        /// </summary>
        [Test]
        public void TestChangeDocumentProtection()
        {
            string remoteFileName = "TestChangeDocumentProtection.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new ProtectDocumentRequest(
                name: remoteFileName,
                protectionRequest: new ProtectionRequest()
                {
                    NewPassword = "321"
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.ProtectDocument(request);
        }

        /// <summary>
        /// Test for deleting unprotect document.
        /// </summary>
        [Test]
        public void TestDeleteUnprotectDocument()
        {
            string localFilePath = "DocumentActions/DocumentProtection/SampleProtectedBlankWordDocument.docx";
            string remoteFileName = "TestDeleteUnprotectDocument.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFilePath)
            );

            var request = new UnprotectDocumentRequest(
                name: remoteFileName,
                protectionRequest: new ProtectionRequest()
                {
                    Password = "aspose"
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UnprotectDocument(request);
        }
    }
}
