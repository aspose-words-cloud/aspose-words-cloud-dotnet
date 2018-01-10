// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="DocumentProtection.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.DocumentProtection
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to set document protection
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class DocumentProtection : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentActions/Protection");

        private readonly string protectionFolder = "DocumentProtection/";

        /// <summary>
        /// Test for setting document protection
        /// </summary>
        [TestMethod]
        public void TestPutProtectDocument()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPutProtectDocument.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new ProtectionRequest { NewPassword = "123" };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PutProtectDocumentRequest(remoteName, body, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.PutProtectDocument(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting document protection
        /// </summary>
        [TestMethod]
        public void TestGetDocumentProtection()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentProtection.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentProtectionRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetDocumentProtection(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for changing document protection
        /// </summary>
        [TestMethod]
        public void TestPostChangeDocumentProtection()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostChangeDocumentProtection.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var body = new ProtectionRequest { NewPassword = string.Empty };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PostChangeDocumentProtectionRequest(remoteName, body, this.dataFolder);
            var actual = this.WordsApi.PostChangeDocumentProtection(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting unprotect document
        /// </summary>
        [TestMethod]
        public void TestDeleteUnprotectDocument()
        {
            var localName = "SampleProtectedBlankWordDocument.docx";
            var remoteName = "TestDeleteUnprotectDocument.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var body = new ProtectionRequest { Password = "aspose" };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.protectionFolder) + localName));

            var request = new DeleteUnprotectDocumentRequest(remoteName, body, this.dataFolder);
            var actual = this.WordsApi.DeleteUnprotectDocument(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}