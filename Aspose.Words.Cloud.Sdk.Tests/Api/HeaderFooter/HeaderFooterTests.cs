// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HeaderFooterTests.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.HeaderFooter
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with headers and footers.
    /// </summary>
    [TestFixture]
    public class HeaderFooterTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/HeaderFooters";
        private readonly string localFile = "DocumentElements/HeaderFooters/HeadersFooters.doc";

        /// <summary>
        /// Test for getting headers and footers.
        /// </summary>
        [Test]
        public async Task TestGetHeaderFooters()
        {
            string remoteFileName = "TestGetHeadersFooters.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetHeaderFootersRequest(
                name: remoteFileName,
                sectionPath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetHeaderFooters(request);
            Assert.NotNull(actual.HeaderFooters);
            Assert.NotNull(actual.HeaderFooters.List);
            Assert.AreEqual(6, actual.HeaderFooters.List.Count);
        }

        /// <summary>
        /// Test for getting headers and footers online.
        /// </summary>
        [Test]
        public async Task TestGetHeaderFootersOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetHeaderFootersOnlineRequest(
                document: requestDocument,
                sectionPath: ""
            );
            var actual = await this.WordsApi.GetHeaderFootersOnline(request);
        }

        /// <summary>
        /// Test for getting headerfooter.
        /// </summary>
        [Test]
        public async Task TestGetHeaderFooter()
        {
            string remoteFileName = "TestGetHeaderFooter.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetHeaderFooterRequest(
                name: remoteFileName,
                headerFooterIndex: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetHeaderFooter(request);
            Assert.NotNull(actual.HeaderFooter);
            Assert.NotNull(actual.HeaderFooter.ChildNodes);
            Assert.AreEqual(1, actual.HeaderFooter.ChildNodes.Count);
            Assert.AreEqual("0.0.0", actual.HeaderFooter.ChildNodes[0].NodeId);
        }

        /// <summary>
        /// Test for getting headerfooter online.
        /// </summary>
        [Test]
        public async Task TestGetHeaderFooterOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetHeaderFooterOnlineRequest(
                document: requestDocument,
                headerFooterIndex: 0
            );
            var actual = await this.WordsApi.GetHeaderFooterOnline(request);
        }

        /// <summary>
        /// Test for getting headerfooter of section.
        /// </summary>
        [Test]
        public async Task TestGetHeaderFooterOfSection()
        {
            string remoteFileName = "TestGetHeaderFooterOfSection.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetHeaderFooterOfSectionRequest(
                name: remoteFileName,
                headerFooterIndex: 0,
                sectionIndex: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetHeaderFooterOfSection(request);
            Assert.NotNull(actual.HeaderFooter);
            Assert.NotNull(actual.HeaderFooter.ChildNodes);
            Assert.AreEqual(1, actual.HeaderFooter.ChildNodes.Count);
            Assert.AreEqual("0.0.0", actual.HeaderFooter.ChildNodes[0].NodeId);
        }

        /// <summary>
        /// Test for getting headerfooter of section online.
        /// </summary>
        [Test]
        public async Task TestGetHeaderFooterOfSectionOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetHeaderFooterOfSectionOnlineRequest(
                document: requestDocument,
                headerFooterIndex: 0,
                sectionIndex: 0
            );
            var actual = await this.WordsApi.GetHeaderFooterOfSectionOnline(request);
        }

        /// <summary>
        /// Test for deleting headerfooter.
        /// </summary>
        [Test]
        public async Task TestDeleteHeaderFooter()
        {
            string remoteFileName = "TestDeleteHeaderFooter.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteHeaderFooterRequest(
                name: remoteFileName,
                sectionPath: "",
                index: 0,
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteHeaderFooter(request);
        }

        /// <summary>
        /// Test for deleting headerfooter online.
        /// </summary>
        [Test]
        public async Task TestDeleteHeaderFooterOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteHeaderFooterOnlineRequest(
                document: requestDocument,
                sectionPath: "",
                index: 0
            );
            var actual = await this.WordsApi.DeleteHeaderFooterOnline(request);
        }

        /// <summary>
        /// Test for deleting headerfooters.
        /// </summary>
        [Test]
        public async Task TestDeleteHeadersFooters()
        {
            string remoteFileName = "TestDeleteHeadersFooters.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteHeadersFootersRequest(
                name: remoteFileName,
                sectionPath: "",
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteHeadersFooters(request);
        }

        /// <summary>
        /// Test for deleting headerfooters online.
        /// </summary>
        [Test]
        public async Task TestDeleteHeadersFootersOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteHeadersFootersOnlineRequest(
                document: requestDocument,
                sectionPath: ""
            );
            var actual = await this.WordsApi.DeleteHeadersFootersOnline(request);
        }

        /// <summary>
        /// Test for adding headerfooters.
        /// </summary>
        [Test]
        public async Task TestInsertHeaderFooter()
        {
            string remoteFileName = "TestInsertHeaderFooter.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertHeaderFooterRequest(
                name: remoteFileName,
                sectionPath: "",
                headerFooterType: "FooterEven",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertHeaderFooter(request);
        }

        /// <summary>
        /// Test for adding headerfooters online.
        /// </summary>
        [Test]
        public async Task TestInsertHeaderFooterOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertHeaderFooterOnlineRequest(
                document: requestDocument,
                sectionPath: "",
                headerFooterType: "FooterEven"
            );
            var actual = await this.WordsApi.InsertHeaderFooterOnline(request);
            Assert.NotNull(actual.Model.HeaderFooter);
            Assert.NotNull(actual.Model.HeaderFooter.ChildNodes);
            Assert.AreEqual(1, actual.Model.HeaderFooter.ChildNodes.Count);
            Assert.AreEqual("0.2.0", actual.Model.HeaderFooter.ChildNodes[0].NodeId);
        }
    }
}
