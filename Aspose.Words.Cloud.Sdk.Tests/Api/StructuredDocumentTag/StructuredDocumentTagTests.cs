// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StructuredDocumentTagTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.StructuredDocumentTag
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to use structured document tags.
    /// </summary>
    [TestFixture]
    public class StructuredDocumentTagTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/StructuredDocumentTag";
        private readonly string localFile = "DocumentElements/StructuredDocumentTag/StructuredDocumentTag.docx";

        /// <summary>
        /// Test for getting SDT objects from document.
        /// </summary>
        [Test]
        public async Task TestGetStructuredDocumentTags()
        {
            string remoteFileName = "TestGetStructuredDocumentTags.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetStructuredDocumentTagsRequest(
                name: remoteFileName,
                nodePath: "sections/0/body/paragraphs/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetStructuredDocumentTags(request);
        }

        /// <summary>
        /// Test for getting SDT objects from document online.
        /// </summary>
        [Test]
        public async Task TestGetStructuredDocumentTagsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetStructuredDocumentTagsOnlineRequest(
                document: requestDocument,
                nodePath: "sections/0/body/paragraphs/0"
            );
            var actual = await this.WordsApi.GetStructuredDocumentTagsOnline(request);
        }

        /// <summary>
        /// Test for getting SDT object from document.
        /// </summary>
        [Test]
        public async Task TestGetStructuredDocumentTag()
        {
            string remoteFileName = "TestGetStructuredDocumentTag.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetStructuredDocumentTagRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0/body/paragraphs/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetStructuredDocumentTag(request);
        }

        /// <summary>
        /// Test for getting SDT object from document online.
        /// </summary>
        [Test]
        public async Task TestGetStructuredDocumentTagOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetStructuredDocumentTagOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0/body/paragraphs/0"
            );
            var actual = await this.WordsApi.GetStructuredDocumentTagOnline(request);
        }

        /// <summary>
        /// Test for adding SDT object.
        /// </summary>
        [Test]
        public async Task TestInsertStructuredDocumentTag()
        {
            string remoteFileName = "TestInsetStructuredDocumentTag.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestStructuredDocumentTag = new StructuredDocumentTagInsert()
            {
                SdtType = StructuredDocumentTagInsert.SdtTypeEnum.ComboBox,
                Level = StructuredDocumentTagInsert.LevelEnum.Inline
            };
            var request = new InsertStructuredDocumentTagRequest(
                name: remoteFileName,
                structuredDocumentTag: requestStructuredDocumentTag,
                nodePath: "sections/0/body/paragraphs/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertStructuredDocumentTag(request);
        }

        /// <summary>
        /// Test for adding SDT object online.
        /// </summary>
        [Test]
        public async Task TestInsertStructuredDocumentTagOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestStructuredDocumentTag = new StructuredDocumentTagInsert()
            {
                SdtType = StructuredDocumentTagInsert.SdtTypeEnum.ComboBox,
                Level = StructuredDocumentTagInsert.LevelEnum.Inline
            };
            var request = new InsertStructuredDocumentTagOnlineRequest(
                document: requestDocument,
                structuredDocumentTag: requestStructuredDocumentTag,
                nodePath: "sections/0/body/paragraphs/0"
            );
            var actual = await this.WordsApi.InsertStructuredDocumentTagOnline(request);
        }

        /// <summary>
        /// Test for deleting SDT object.
        /// </summary>
        [Test]
        public async Task TestDeleteStructuredDocumentTag()
        {
            string remoteFileName = "TestDeleteStructuredDocumentTag.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteStructuredDocumentTagRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0/body/paragraphs/0",
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteStructuredDocumentTag(request);
        }

        /// <summary>
        /// Test for deleting SDT object online.
        /// </summary>
        [Test]
        public async Task TestDeleteStructuredDocumentTagOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteStructuredDocumentTagOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0/body/paragraphs/0"
            );
            var actual = await this.WordsApi.DeleteStructuredDocumentTagOnline(request);
        }

        /// <summary>
        /// Test for updating SDT object.
        /// </summary>
        [Test]
        public async Task TestUpdateStructuredDocumentTag()
        {
            string remoteFileName = "TestUpdateStructuredDocumentTag.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestStructuredDocumentTagListItems0 = new StructuredDocumentTagListItem()
            {
                DisplayText = "Aspose Words",
                Value = "1"
            };
            var requestStructuredDocumentTagListItems1 = new StructuredDocumentTagListItem()
            {
                DisplayText = "Hello world",
                Value = "2"
            };
            var requestStructuredDocumentTagListItems = new List<StructuredDocumentTagListItem>()
            {
                requestStructuredDocumentTagListItems0,
                requestStructuredDocumentTagListItems1
            };
            var requestStructuredDocumentTag = new StructuredDocumentTagUpdate()
            {
                ListItems = requestStructuredDocumentTagListItems
            };
            var request = new UpdateStructuredDocumentTagRequest(
                name: remoteFileName,
                index: 0,
                structuredDocumentTag: requestStructuredDocumentTag,
                nodePath: "sections/0/body/paragraphs/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateStructuredDocumentTag(request);
        }

        /// <summary>
        /// Test for updating SDT object online.
        /// </summary>
        [Test]
        public async Task TestUpdateStructuredDocumentTagOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestStructuredDocumentTagListItems0 = new StructuredDocumentTagListItem()
            {
                DisplayText = "Aspose Words",
                Value = "1"
            };
            var requestStructuredDocumentTagListItems1 = new StructuredDocumentTagListItem()
            {
                DisplayText = "Hello world",
                Value = "2"
            };
            var requestStructuredDocumentTagListItems = new List<StructuredDocumentTagListItem>()
            {
                requestStructuredDocumentTagListItems0,
                requestStructuredDocumentTagListItems1
            };
            var requestStructuredDocumentTag = new StructuredDocumentTagUpdate()
            {
                ListItems = requestStructuredDocumentTagListItems
            };
            var request = new UpdateStructuredDocumentTagOnlineRequest(
                document: requestDocument,
                structuredDocumentTag: requestStructuredDocumentTag,
                index: 0,
                nodePath: "sections/0/body/paragraphs/0"
            );
            var actual = await this.WordsApi.UpdateStructuredDocumentTagOnline(request);
        }
    }
}
