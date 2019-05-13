// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="HeaderFooterTest.cs">
// //   Copyright (c) 2019 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Tests.HeaderFooter
{
    using System.IO;
    
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with headers and footers
    /// </summary>
    [TestFixture]
    public class HeaderFooterTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/HeaderFooters");

        private readonly string headerFooterFolder = "DocumentElements/HeaderFooters/";

        /// <summary>
        /// Test for getting headers and footers
        /// </summary>
        [Test]
        public void TestGetHeadersFooters()
        {
            var localName = "HeadersFooters.doc";
            var remoteName = "TestGetHeadersFooters.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.headerFooterFolder) + localName));

            var request = new GetHeaderFootersRequest(remoteName, null, this.dataFolder);
            var actual = this.WordsApi.GetHeaderFooters(request);
        }

        /// <summary>
        /// Test for getting headerfooter
        /// </summary>
        [Test]
        public void TestGetHeaderFooter()
        {
            var localName = "HeadersFooters.doc";
            var remoteName = "TestGetHeaderFooter.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.headerFooterFolder) + localName));

            var request = new GetHeaderFooterRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.GetHeaderFooter(request);
        }

        /// <summary>
        /// Test for getting headerfooter of section
        /// </summary>
        [Test]
        public void TestGetHeaderFooterOfSection()
        {
            var localName = "HeadersFooters.doc";
            var remoteName = "TestGetHeaderFooterOfSection.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var sectionIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.headerFooterFolder) + localName));

            var request = new GetHeaderFooterOfSectionRequest(remoteName, index, sectionIndex, this.dataFolder);
            var actual = this.WordsApi.GetHeaderFooterOfSection(request);
        }

        /// <summary>
        /// Test for deleting headerfooter
        /// </summary>
        [Test]
        public void TestDeleteHeaderFooter()
        {
            var localName = "HeadersFooters.doc";
            var remoteName = "TestDeleteHeaderFooter.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.headerFooterFolder) + localName));

            var request = new DeleteHeaderFooterRequest(remoteName, index, null, this.dataFolder);
            this.WordsApi.DeleteHeaderFooter(request);
        }

        /// <summary>
        /// Test for deleting headerfooters
        /// </summary>
        [Test]
        public void TestDeleteHeaderFooters()
        {
            var localName = "HeadersFooters.doc";
            var remoteName = "TestDeleteHeaderFooters.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.headerFooterFolder) + localName));

            var request = new DeleteHeadersFootersRequest(remoteName, null, this.dataFolder);
            this.WordsApi.DeleteHeadersFooters(request);
        }

        /// <summary>
        /// Test for adding headerfooters
        /// </summary>
        [Test]
        public void TestInsertHeaderFooter()
        {
            var localName = "HeadersFooters.doc";
            var remoteName = "TestInsertHeaderFooter.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.headerFooterFolder) + localName));

            var request = new InsertHeaderFooterRequest(remoteName, "FooterEven", null,  this.dataFolder);
            var actual = this.WordsApi.InsertHeaderFooter(request);
        }
    }
}