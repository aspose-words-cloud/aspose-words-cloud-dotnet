// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SectionTests.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Sections
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with sections.
    /// </summary>
    [TestFixture]
    public class SectionTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Section";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for getting section by index.
        /// </summary>
        [Test]
        public async Task TestGetSection()
        {
            string remoteFileName = "TestGetSection.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetSectionRequest(
                name: remoteFileName,
                sectionIndex: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetSection(request);
            Assert.NotNull(actual.Section);
            Assert.NotNull(actual.Section.ChildNodes);
            Assert.AreEqual(13, actual.Section.ChildNodes.Count);
            Assert.AreEqual("0.3.0", actual.Section.ChildNodes[0].NodeId);
        }

        /// <summary>
        /// Test for getting section by index online.
        /// </summary>
        [Test]
        public async Task TestGetSectionOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetSectionOnlineRequest(
                document: requestDocument,
                sectionIndex: 0
            );
            var actual = await this.WordsApi.GetSectionOnline(request);
        }

        /// <summary>
        /// Test for getting sections.
        /// </summary>
        [Test]
        public async Task TestGetSections()
        {
            string remoteFileName = "TestGetSections.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetSectionsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetSections(request);
            Assert.NotNull(actual.Sections);
            Assert.NotNull(actual.Sections.SectionLinkList);
            Assert.AreEqual(1, actual.Sections.SectionLinkList.Count);
            Assert.AreEqual("0", actual.Sections.SectionLinkList[0].NodeId);
        }

        /// <summary>
        /// Test for getting sections online.
        /// </summary>
        [Test]
        public async Task TestGetSectionsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetSectionsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetSectionsOnline(request);
        }

        /// <summary>
        /// Test for delete a section.
        /// </summary>
        [Test]
        public async Task TestDeleteSection()
        {
            string remoteFileName = "TestDeleteSection.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteSectionRequest(
                name: remoteFileName,
                sectionIndex: 0,
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteSection(request);
        }

        /// <summary>
        /// Test for delete a section online.
        /// </summary>
        [Test]
        public async Task TestDeleteSectionOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteSectionOnlineRequest(
                document: requestDocument,
                sectionIndex: 0
            );
            var actual = await this.WordsApi.DeleteSectionOnline(request);
        }

        /// <summary>
        /// Test for linking headers and footers to previous section.
        /// </summary>
        [Test]
        public async Task TestLinkHeaderFootersToPrevious()
        {
            string remoteFileName = "TestLinkHeaderFootersToPrevious.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "DocumentElements/Sections/Source.docx")
            );

            var request = new LinkHeaderFootersToPreviousRequest(
                name: remoteFileName,
                sectionIndex: 1,
                folder: remoteDataFolder
            );
        await this.WordsApi.LinkHeaderFootersToPrevious(request);
        }
    }
}
