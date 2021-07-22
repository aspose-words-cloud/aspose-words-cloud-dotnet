// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HeaderFooterTests.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
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
        public void TestGetHeaderFooters()
        {
            string remoteFileName = "TestGetHeadersFooters.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetHeaderFooters(request);
            Assert.NotNull(actual.HeaderFooters);
            Assert.NotNull(actual.HeaderFooters.List);
            Assert.AreEqual(6, actual.HeaderFooters.List.Count);
        }

        /// <summary>
        /// Test for getting headers and footers online.
        /// </summary>
        [Test]
        public void TestGetHeaderFootersOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetHeaderFootersOnlineRequest(
                document: requestDocumentStream,
                sectionPath: ""
            );
            var actual = this.WordsApi.GetHeaderFootersOnline(request);
        }

        /// <summary>
        /// Test for getting headerfooter.
        /// </summary>
        [Test]
        public void TestGetHeaderFooter()
        {
            string remoteFileName = "TestGetHeaderFooter.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetHeaderFooter(request);
            Assert.NotNull(actual.HeaderFooter);
            Assert.NotNull(actual.HeaderFooter.ChildNodes);
            Assert.AreEqual(1, actual.HeaderFooter.ChildNodes.Count);
            Assert.AreEqual("0.0.0", actual.HeaderFooter.ChildNodes[0].NodeId);
        }

        /// <summary>
        /// Test for getting headerfooter online.
        /// </summary>
        [Test]
        public void TestGetHeaderFooterOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetHeaderFooterOnlineRequest(
                document: requestDocumentStream,
                headerFooterIndex: 0
            );
            var actual = this.WordsApi.GetHeaderFooterOnline(request);
        }

        /// <summary>
        /// Test for getting headerfooter of section.
        /// </summary>
        [Test]
        public void TestGetHeaderFooterOfSection()
        {
            string remoteFileName = "TestGetHeaderFooterOfSection.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetHeaderFooterOfSection(request);
            Assert.NotNull(actual.HeaderFooter);
            Assert.NotNull(actual.HeaderFooter.ChildNodes);
            Assert.AreEqual(1, actual.HeaderFooter.ChildNodes.Count);
            Assert.AreEqual("0.0.0", actual.HeaderFooter.ChildNodes[0].NodeId);
        }

        /// <summary>
        /// Test for getting headerfooter of section online.
        /// </summary>
        [Test]
        public void TestGetHeaderFooterOfSectionOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetHeaderFooterOfSectionOnlineRequest(
                document: requestDocumentStream,
                headerFooterIndex: 0,
                sectionIndex: 0
            );
            var actual = this.WordsApi.GetHeaderFooterOfSectionOnline(request);
        }

        /// <summary>
        /// Test for deleting headerfooter.
        /// </summary>
        [Test]
        public void TestDeleteHeaderFooter()
        {
            string remoteFileName = "TestDeleteHeaderFooter.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteHeaderFooter(request);
        }

        /// <summary>
        /// Test for deleting headerfooter online.
        /// </summary>
        [Test]
        public void TestDeleteHeaderFooterOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteHeaderFooterOnlineRequest(
                document: requestDocumentStream,
                sectionPath: "",
                index: 0
            );
            var actual = this.WordsApi.DeleteHeaderFooterOnline(request);
        }

        /// <summary>
        /// Test for deleting headerfooters.
        /// </summary>
        [Test]
        public void TestDeleteHeadersFooters()
        {
            string remoteFileName = "TestDeleteHeadersFooters.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteHeadersFooters(request);
        }

        /// <summary>
        /// Test for deleting headerfooters online.
        /// </summary>
        [Test]
        public void TestDeleteHeadersFootersOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteHeadersFootersOnlineRequest(
                document: requestDocumentStream,
                sectionPath: ""
            );
            var actual = this.WordsApi.DeleteHeadersFootersOnline(request);
        }

        /// <summary>
        /// Test for adding headerfooters.
        /// </summary>
        [Test]
        public void TestInsertHeaderFooter()
        {
            string remoteFileName = "TestInsertHeaderFooter.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.InsertHeaderFooter(request);
        }

        /// <summary>
        /// Test for adding headerfooters online.
        /// </summary>
        [Test]
        public void TestInsertHeaderFooterOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertHeaderFooterOnlineRequest(
                document: requestDocumentStream,
                sectionPath: "",
                headerFooterType: "FooterEven"
            );
            var actual = this.WordsApi.InsertHeaderFooterOnline(request);
            Assert.NotNull(actual.Model.HeaderFooter);
            Assert.NotNull(actual.Model.HeaderFooter.ChildNodes);
            Assert.AreEqual(1, actual.Model.HeaderFooter.ChildNodes.Count);
            Assert.AreEqual("0.2.0", actual.Model.HeaderFooter.ChildNodes[0].NodeId);
        }
    }
}
