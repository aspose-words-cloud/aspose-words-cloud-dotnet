// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HeaderFooterTests.cs">
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
                sectionPath: null,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetHeaderFooters(request);
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
                sectionPath: null,
                index: 0,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteHeaderFooter(request);
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
                sectionPath: null,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteHeadersFooters(request);
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
                headerFooterType: "FooterEven",
                sectionPath: null,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertHeaderFooter(request);
        }
    }
}
