// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RevisionsTests.cs">
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
    /// Example of how to accept all revisions in document.
    /// </summary>
    [TestFixture]
    public class RevisionsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/Revisions";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for accepting revisions in document.
        /// </summary>
        [Test]
        public async Task TestAcceptAllRevisions()
        {
            string remoteFileName = "TestAcceptAllRevisions.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new AcceptAllRevisionsRequest(
                name: remoteFileName,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.AcceptAllRevisions(request);
            Assert.NotNull(actual.Result);
            Assert.NotNull(actual.Result.Dest);
        }

        /// <summary>
        /// Test for accepting revisions in document online.
        /// </summary>
        [Test]
        public async Task TestAcceptAllRevisionsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new AcceptAllRevisionsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.AcceptAllRevisionsOnline(request);
            Assert.NotNull(actual.Document);
            Assert.NotNull(actual.Model);
            Assert.NotNull(actual.Model.Result);
            Assert.NotNull(actual.Model.Result.Dest);
        }

        /// <summary>
        /// Test for rejecting revisions in document.
        /// </summary>
        [Test]
        public async Task TestRejectAllRevisions()
        {
            string remoteFileName = "TestRejectAllRevisions.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RejectAllRevisionsRequest(
                name: remoteFileName,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.RejectAllRevisions(request);
            Assert.NotNull(actual.Result);
            Assert.NotNull(actual.Result.Dest);
        }

        /// <summary>
        /// Test for rejecting revisions in document online.
        /// </summary>
        [Test]
        public async Task TestRejectAllRevisionsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new RejectAllRevisionsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.RejectAllRevisionsOnline(request);
            Assert.NotNull(actual.Document);
            Assert.NotNull(actual.Model);
            Assert.NotNull(actual.Model.Result);
            Assert.NotNull(actual.Model.Result.Dest);
        }

        /// <summary>
        /// Test for getting revisions from document.
        /// </summary>
        [Test]
        public async Task TestGetAllRevisions()
        {
            string remoteFileName = "TestAcceptAllRevisions.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetAllRevisionsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetAllRevisions(request);
            Assert.NotNull(actual.Revisions);
            Assert.AreEqual(6, actual.Revisions.Revisions.Count);
        }

        /// <summary>
        /// Test for getting revisions online from document.
        /// </summary>
        [Test]
        public async Task TestGetAllRevisionsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetAllRevisionsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetAllRevisionsOnline(request);
            Assert.NotNull(actual.Revisions);
            Assert.AreEqual(6, actual.Revisions.Revisions.Count);
        }
    }
}
