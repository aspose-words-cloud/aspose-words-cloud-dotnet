// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SignatureTests.cs">
//   Copyright (c) 2026 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Document
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with signatures.
    /// </summary>
    [TestFixture]
    public class SignatureTests : BaseTestContext
    {
        private readonly string remoteFolder = RemoteBaseTestDataFolder + "/DocumentActions/Signature";
        private readonly string localFolder = "DocumentActions/Signature";
        private readonly string signedDocument = "signedDocument.docx";
        private readonly string unsignedDocument = "unsignedDocument.docx";
        private readonly string certificateName = "morzal.pfx";
        private readonly string certificatePassword = "aw";

        /// <summary>
        /// Test for getting all document signatures.
        /// </summary>
        [Test]
        public async Task TestGetSignatures()
        {
            string remoteName = "TestGetSignatures.docx";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + signedDocument)
            );

            var request = new GetSignaturesRequest(
                name: remoteName,
                folder: remoteFolder
            );
            var actual = await this.WordsApi.GetSignatures(request);
            Assert.NotNull(actual.Signatures);
            Assert.AreEqual(1, actual.Signatures.Count);
        }

        /// <summary>
        /// Test for getting all document signatures online.
        /// </summary>
        [Test]
        public async Task TestGetSignaturesOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/" + signedDocument);
            var request = new GetSignaturesOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetSignaturesOnline(request);
            Assert.NotNull(actual.Signatures);
            Assert.AreEqual(1, actual.Signatures.Count);
        }

        /// <summary>
        /// Test for removing all document signatures.
        /// </summary>
        [Test]
        public async Task TestRemoveAllSignatures()
        {
            string remoteName = "TestRemoveAllSignatures.docx";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + signedDocument)
            );

            var request = new RemoveAllSignaturesRequest(
                name: remoteName,
                folder: remoteFolder
            );
            var actual = await this.WordsApi.RemoveAllSignatures(request);
            Assert.NotNull(actual.Signatures);
            Assert.AreEqual(0, actual.Signatures.Count);
        }

        /// <summary>
        /// Test for removing all document signatures online.
        /// </summary>
        [Test]
        public async Task TestRemoveAllSignaturesOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/" + signedDocument);
            var request = new RemoveAllSignaturesOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.RemoveAllSignaturesOnline(request);
            Assert.NotNull(actual.Model.Signatures);
            Assert.AreEqual(0, actual.Model.Signatures.Count);
        }

        /// <summary>
        /// Test for signing document.
        /// </summary>
        [Test]
        public async Task TestSignDocument()
        {
            string remoteName = "TestSignDocument.docx";
            string remoteCertificateName = "TestCertificate.pfx";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + unsignedDocument)
            );
            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteCertificateName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + certificateName)
            );

            var request = new SignDocumentRequest(
                name: remoteName,
                certificatePath: remoteFolder + "/" + remoteCertificateName,
                certificatePassword: certificatePassword,
                folder: remoteFolder
            );
            var actual = await this.WordsApi.SignDocument(request);
            Assert.NotNull(actual.Signatures);
            Assert.AreEqual(1, actual.Signatures.Count);
        }

        /// <summary>
        /// Test for signing document online.
        /// </summary>
        [Test]
        public async Task TestSignDocumentOnline()
        {
            string remoteCertificateName = "TestCertificateOnline.pfx";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteCertificateName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + certificateName)
            );

            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/" + unsignedDocument);
            var request = new SignDocumentOnlineRequest(
                document: requestDocument,
                certificatePath: remoteFolder + "/" + remoteCertificateName,
                certificatePassword: certificatePassword
            );
            var actual = await this.WordsApi.SignDocumentOnline(request);
            Assert.NotNull(actual.Model.Signatures);
            Assert.AreEqual(1, actual.Model.Signatures.Count);
        }
    }
}
