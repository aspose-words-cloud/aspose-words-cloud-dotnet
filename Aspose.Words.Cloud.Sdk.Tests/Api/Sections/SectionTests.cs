// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SectionTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Sections
{
    using System.Collections.Generic;
    using System.IO;
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
        public void TestGetSection()
        {
            string remoteFileName = "TestGetSection.docx";

            this.UploadFileToStorage(
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

            var actual = this.WordsApi.GetSection(request);
            Assert.NotNull(actual.Section);
            Assert.NotNull(actual.Section.ChildNodes);
            Assert.AreEqual(13, actual.Section.ChildNodes.Count);
            Assert.AreEqual("0.3.0", actual.Section.ChildNodes[0].NodeId);
        }

        /// <summary>
        /// Test for getting section by index online.
        /// </summary>
        [Test]
        public void TestGetSectionOnline()
        {
            var request = new GetSectionOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                sectionIndex: 0
            );

            var actual = this.WordsApi.GetSectionOnline(request);
        }

        /// <summary>
        /// Test for getting sections.
        /// </summary>
        [Test]
        public void TestGetSections()
        {
            string remoteFileName = "TestGetSections.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetSectionsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetSections(request);
            Assert.NotNull(actual.Sections);
            Assert.NotNull(actual.Sections.SectionLinkList);
            Assert.AreEqual(1, actual.Sections.SectionLinkList.Count);
            Assert.AreEqual("0", actual.Sections.SectionLinkList[0].NodeId);
        }

        /// <summary>
        /// Test for getting sections online.
        /// </summary>
        [Test]
        public void TestGetSectionsOnline()
        {
            var request = new GetSectionsOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile)
            );

            var actual = this.WordsApi.GetSectionsOnline(request);
        }

        /// <summary>
        /// Test for delete a section.
        /// </summary>
        [Test]
        public void TestDeleteSection()
        {
            string remoteFileName = "TestDeleteSection.docx";

            this.UploadFileToStorage(
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

            this.WordsApi.DeleteSection(request);
        }

        /// <summary>
        /// Test for delete a section online.
        /// </summary>
        [Test]
        public void TestDeleteSectionOnline()
        {
            var request = new DeleteSectionOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                sectionIndex: 0
            );

            var actual = this.WordsApi.DeleteSectionOnline(request);
        }
    }
}
