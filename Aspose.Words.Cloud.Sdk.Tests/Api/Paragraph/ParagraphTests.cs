// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ParagraphTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Paragraph
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with paragraph.
    /// </summary>
    [TestFixture]
    public class ParagraphTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Paragraphs";
        private readonly string localFile = "Common/test_multi_pages.docx";
        private readonly string listFolder = "DocumentElements/ParagraphListFormat";
        private readonly string tabStopFolder = "DocumentElements/Paragraphs";

        /// <summary>
        /// Test for getting paragraph.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphByIndex()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndex.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.0.0", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for getting paragraph online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetParagraphOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetParagraphOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph without node path.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphByIndexWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndexWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.0.0", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for getting all paragraphs.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphs()
        {
            string remoteFileName = "TestGetDocumentParagraphs.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphs(request);
            Assert.NotNull(actual.Paragraphs);
            Assert.NotNull(actual.Paragraphs.ParagraphLinkList);
            Assert.AreEqual(15, actual.Paragraphs.ParagraphLinkList.Count);
            Assert.AreEqual("Page 1 of 3", actual.Paragraphs.ParagraphLinkList[0].Text);
        }

        /// <summary>
        /// Test for getting all paragraphs online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetParagraphsOnlineRequest(
                document: requestDocument,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.GetParagraphsOnline(request);
        }

        /// <summary>
        /// Test for getting all paragraphs without node path.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphsWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentParagraphsWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphs(request);
            Assert.NotNull(actual.Paragraphs);
            Assert.NotNull(actual.Paragraphs.ParagraphLinkList);
            Assert.AreEqual(15, actual.Paragraphs.ParagraphLinkList.Count);
            Assert.AreEqual("Page 1 of 3", actual.Paragraphs.ParagraphLinkList[0].Text);
        }

        /// <summary>
        /// Test for getting paragraph run.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphRun()
        {
            string remoteFileName = "TestGetDocumentParagraphRun.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetRunRequest(
                name: remoteFileName,
                paragraphPath: "paragraphs/0",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetRun(request);
            Assert.NotNull(actual.Run);
            Assert.AreEqual("Page ", actual.Run.Text);
        }

        /// <summary>
        /// Test for getting paragraph run online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphRunOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetRunOnlineRequest(
                document: requestDocument,
                paragraphPath: "paragraphs/0",
                index: 0
            );
            var actual = await this.WordsApi.GetRunOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph run font.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphRunFont()
        {
            string remoteFileName = "TestGetDocumentParagraphRunFont.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetRunFontRequest(
                name: remoteFileName,
                paragraphPath: "paragraphs/0",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetRunFont(request);
            Assert.NotNull(actual.Font);
            Assert.AreEqual("Times New Roman", actual.Font.Name);
        }

        /// <summary>
        /// Test for getting paragraph run font online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentParagraphRunFontOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetRunFontOnlineRequest(
                document: requestDocument,
                paragraphPath: "paragraphs/0",
                index: 0
            );
            var actual = await this.WordsApi.GetRunFontOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph runs.
        /// </summary>
        [Test]
        public async Task TestGetParagraphRuns()
        {
            string remoteFileName = "TestGetParagraphRuns.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetRunsRequest(
                name: remoteFileName,
                paragraphPath: "sections/0/paragraphs/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetRuns(request);
            Assert.NotNull(actual.Runs);
            Assert.NotNull(actual.Runs.List);
            Assert.AreEqual(6, actual.Runs.List.Count);
            Assert.AreEqual("Page ", actual.Runs.List[0].Text);
        }

        /// <summary>
        /// Test for getting paragraph runs online.
        /// </summary>
        [Test]
        public async Task TestGetParagraphRunsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetRunsOnlineRequest(
                document: requestDocument,
                paragraphPath: "sections/0/paragraphs/0"
            );
            var actual = await this.WordsApi.GetRunsOnline(request);
        }

        /// <summary>
        /// Test for updating paragraph run font.
        /// </summary>
        [Test]
        public async Task TestUpdateRunFont()
        {
            string remoteFileName = "TestUpdateRunFont.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestFontDto = new Font()
            {
                Bold = true
            };
            var request = new UpdateRunFontRequest(
                name: remoteFileName,
                paragraphPath: "paragraphs/0",
                index: 0,
                fontDto: requestFontDto,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.UpdateRunFont(request);
            Assert.NotNull(actual.Font);
            Assert.AreEqual(true, actual.Font.Bold);
        }

        /// <summary>
        /// Test for updating paragraph run font online.
        /// </summary>
        [Test]
        public async Task TestUpdateRunFontOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestFontDto = new Font()
            {
                Bold = true
            };
            var request = new UpdateRunFontOnlineRequest(
                document: requestDocument,
                paragraphPath: "paragraphs/0",
                fontDto: requestFontDto,
                index: 0
            );
            var actual = await this.WordsApi.UpdateRunFontOnline(request);
        }

        /// <summary>
        /// Test for adding paragraph.
        /// </summary>
        [Test]
        public async Task TestInsertParagraph()
        {
            string remoteFileName = "TestInsertParagraph.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestParagraph = new ParagraphInsert()
            {
                Text = "This is a new paragraph for your document"
            };
            var request = new InsertParagraphRequest(
                name: remoteFileName,
                paragraph: requestParagraph,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.3.8", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for adding paragraph online.
        /// </summary>
        [Test]
        public async Task TestInsertParagraphOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestParagraph = new ParagraphInsert()
            {
                Text = "This is a new paragraph for your document"
            };
            var request = new InsertParagraphOnlineRequest(
                document: requestDocument,
                paragraph: requestParagraph,
                nodePath: "sections/0"
            );
            var actual = await this.WordsApi.InsertParagraphOnline(request);
        }

        /// <summary>
        /// Test for adding paragraph without node path.
        /// </summary>
        [Test]
        public async Task TestInsertParagraphWithoutNodePath()
        {
            string remoteFileName = "TestInsertParagraphWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestParagraph = new ParagraphInsert()
            {
                Text = "This is a new paragraph for your document"
            };
            var request = new InsertParagraphRequest(
                name: remoteFileName,
                paragraph: requestParagraph,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.3.8", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for paragraph rendering.
        /// </summary>
        [Test]
        public async Task TestRenderParagraph()
        {
            string remoteFileName = "TestRenderParagraph.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderParagraphRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.RenderParagraph(request);
        }

        /// <summary>
        /// Test for paragraph rendering.
        /// </summary>
        [Test]
        public async Task TestRenderParagraphOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new RenderParagraphOnlineRequest(
                document: requestDocument,
                format: "png",
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.RenderParagraphOnline(request);
        }

        /// <summary>
        /// Test for paragraph rendering without node path.
        /// </summary>
        [Test]
        public async Task TestRenderParagraphWithoutNodePath()
        {
            string remoteFileName = "TestRenderParagraphWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderParagraphRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.RenderParagraph(request);
        }

        /// <summary>
        /// Test for getting paragraph format settings.
        /// </summary>
        [Test]
        public async Task TestGetParagraphFormat()
        {
            string remoteFileName = "TestGetDocumentParagraphs.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphFormatRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphFormat(request);
            Assert.NotNull(actual.ParagraphFormat);
            Assert.AreEqual("Normal", actual.ParagraphFormat.StyleName);
        }

        /// <summary>
        /// Test for getting paragraph format settings online.
        /// </summary>
        [Test]
        public async Task TestGetParagraphFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetParagraphFormatOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetParagraphFormatOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph format settings without node path.
        /// </summary>
        [Test]
        public async Task TestGetParagraphFormatWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentParagraphsWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphFormatRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphFormat(request);
            Assert.NotNull(actual.ParagraphFormat);
            Assert.AreEqual("Normal", actual.ParagraphFormat.StyleName);
        }

        /// <summary>
        /// Test for updating  paragraph format settings.
        /// </summary>
        [Test]
        public async Task TestUpdateParagraphFormat()
        {
            string remoteFileName = "TestGetDocumentParagraphs.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestParagraphFormatDto = new ParagraphFormatUpdate()
            {
                Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
            };
            var request = new UpdateParagraphFormatRequest(
                name: remoteFileName,
                index: 0,
                paragraphFormatDto: requestParagraphFormatDto,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateParagraphFormat(request);
            Assert.NotNull(actual.ParagraphFormat);

        }

        /// <summary>
        /// Test for updating  paragraph format settings online.
        /// </summary>
        [Test]
        public async Task TestUpdateParagraphFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestParagraphFormatDto = new ParagraphFormatUpdate()
            {
                Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
            };
            var request = new UpdateParagraphFormatOnlineRequest(
                document: requestDocument,
                paragraphFormatDto: requestParagraphFormatDto,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.UpdateParagraphFormatOnline(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraph()
        {
            string remoteFileName = "TestDeleteParagraph.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteParagraphRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteParagraph(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph online.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteParagraphOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.DeleteParagraphOnline(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphWithoutNodePath()
        {
            string remoteFileName = "TestDeleteParagraphWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteParagraphRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteParagraph(request);
        }

        /// <summary>
        /// Test for getting paragraph list format.
        /// </summary>
        [Test]
        public async Task TestGetParagraphListFormat()
        {
            string remoteFileName = "TestParagraphGetListFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphGetListFormat.doc")
            );

            var request = new GetParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(1, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for getting paragraph list format online.
        /// </summary>
        [Test]
        public async Task TestGetParagraphListFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + listFolder + "/ParagraphGetListFormat.doc");
            var request = new GetParagraphListFormatOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetParagraphListFormatOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph list format without node path.
        /// </summary>
        [Test]
        public async Task TestGetParagraphListFormatWithoutNodePath()
        {
            string remoteFileName = "TestParagraphGetListFormatWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphGetListFormat.doc")
            );

            var request = new GetParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(1, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for updating paragraph list format.
        /// </summary>
        [Test]
        public async Task TestUpdateParagraphListFormat()
        {
            string remoteFileName = "TestUpdateParagraphListFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphUpdateListFormat.doc")
            );

            var requestListFormatDto = new ListFormatUpdate()
            {
                ListId = 2
            };
            var request = new UpdateParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                listFormatDto: requestListFormatDto,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(2, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for updating paragraph list format online.
        /// </summary>
        [Test]
        public async Task TestUpdateParagraphListFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + listFolder + "/ParagraphUpdateListFormat.doc");
            var requestListFormatDto = new ListFormatUpdate()
            {
                ListId = 2
            };
            var request = new UpdateParagraphListFormatOnlineRequest(
                document: requestDocument,
                listFormatDto: requestListFormatDto,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.UpdateParagraphListFormatOnline(request);
        }

        /// <summary>
        /// Test for updating paragraph list format without node path.
        /// </summary>
        [Test]
        public async Task TestUpdateParagraphListFormatWithoutNodePath()
        {
            string remoteFileName = "TestUpdateParagraphListFormatWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphUpdateListFormat.doc")
            );

            var requestListFormatDto = new ListFormatUpdate()
            {
                ListId = 2
            };
            var request = new UpdateParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                listFormatDto: requestListFormatDto,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(2, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for deleting paragraph list format.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphListFormat()
        {
            string remoteFileName = "TestDeleteParagraphListFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphDeleteListFormat.doc")
            );

            var request = new DeleteParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.DeleteParagraphListFormat(request);
        }

        /// <summary>
        /// Test for deleting paragraph list format online.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphListFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + listFolder + "/ParagraphDeleteListFormat.doc");
            var request = new DeleteParagraphListFormatOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.DeleteParagraphListFormatOnline(request);
        }

        /// <summary>
        /// Test for deleting paragraph list format without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphListFormatWithoutNodePath()
        {
            string remoteFileName = "TestDeleteParagraphListFormatWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphDeleteListFormat.doc")
            );

            var request = new DeleteParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.DeleteParagraphListFormat(request);
        }

        /// <summary>
        /// Test for getting paragraph tab stops.
        /// </summary>
        [Test]
        public async Task TestGetParagraphTabStops()
        {
            string remoteFileName = "TestGetParagraphTabStops.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new GetParagraphTabStopsRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(2, actual.TabStops.Count);
            Assert.AreEqual(72.0f, actual.TabStops[0].Position);
        }

        /// <summary>
        /// Test for getting paragraph tab stops online.
        /// </summary>
        [Test]
        public async Task TestGetParagraphTabStopsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var request = new GetParagraphTabStopsOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetParagraphTabStopsOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph tab stops without node path.
        /// </summary>
        [Test]
        public async Task TestGetParagraphTabStopsWithoutNodePath()
        {
            string remoteFileName = "TestGetParagraphTabStopsWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new GetParagraphTabStopsRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(2, actual.TabStops.Count);
            Assert.AreEqual(72.0f, actual.TabStops[0].Position);
        }

        /// <summary>
        /// Test for inserting paragraph tab stop.
        /// </summary>
        [Test]
        public async Task TestInsertParagraphTabStops()
        {
            string remoteFileName = "TestInsertOrUpdateParagraphTabStop.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var requestTabStopInsertDto = new TabStopInsert()
            {
                Alignment = TabStopInsert.AlignmentEnum.Left,
                Leader = TabStopInsert.LeaderEnum.None,
                Position = 100.0f
            };
            var request = new InsertOrUpdateParagraphTabStopRequest(
                name: remoteFileName,
                index: 0,
                tabStopInsertDto: requestTabStopInsertDto,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertOrUpdateParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(3, actual.TabStops.Count);
            Assert.AreEqual(100.0f, actual.TabStops[1].Position);


        }

        /// <summary>
        /// Test for inserting paragraph tab stop online.
        /// </summary>
        [Test]
        public async Task TestInsertParagraphTabStopsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var requestTabStopInsertDto = new TabStopInsert()
            {
                Alignment = TabStopInsert.AlignmentEnum.Left,
                Leader = TabStopInsert.LeaderEnum.None,
                Position = 72f
            };
            var request = new InsertOrUpdateParagraphTabStopOnlineRequest(
                document: requestDocument,
                tabStopInsertDto: requestTabStopInsertDto,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.InsertOrUpdateParagraphTabStopOnline(request);
        }

        /// <summary>
        /// Test for inserting paragraph tab stop without node path.
        /// </summary>
        [Test]
        public async Task TestInsertParagraphTabStopsWithoutNodePath()
        {
            string remoteFileName = "TestInsertOrUpdateParagraphTabStopWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var requestTabStopInsertDto = new TabStopInsert()
            {
                Alignment = TabStopInsert.AlignmentEnum.Left,
                Leader = TabStopInsert.LeaderEnum.None,
                Position = 100.0f
            };
            var request = new InsertOrUpdateParagraphTabStopRequest(
                name: remoteFileName,
                index: 0,
                tabStopInsertDto: requestTabStopInsertDto,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertOrUpdateParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(3, actual.TabStops.Count);
            Assert.AreEqual(100.0f, actual.TabStops[1].Position);


        }

        /// <summary>
        /// Test for deleting all paragraph tab stops.
        /// </summary>
        [Test]
        public async Task TestDeleteAllParagraphTabStops()
        {
            string remoteFileName = "TestDeleteAllParagraphTabStops.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new DeleteAllParagraphTabStopsRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.DeleteAllParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(0, actual.TabStops.Count);
        }

        /// <summary>
        /// Test for deleting all paragraph tab stops online.
        /// </summary>
        [Test]
        public async Task TestDeleteAllParagraphTabStopsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var request = new DeleteAllParagraphTabStopsOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.DeleteAllParagraphTabStopsOnline(request);
        }

        /// <summary>
        /// Test for deleting all paragraph tab stops without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteAllParagraphTabStopsWithoutNodePath()
        {
            string remoteFileName = "TestDeleteAllParagraphTabStopsWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new DeleteAllParagraphTabStopsRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.DeleteAllParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(0, actual.TabStops.Count);
        }

        /// <summary>
        /// Test for deleting a tab stops.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphTabStop()
        {
            string remoteFileName = "TestDeleteParagraphTabStop.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new DeleteParagraphTabStopRequest(
                name: remoteFileName,
                position: 72.0f,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.DeleteParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(1, actual.TabStops.Count);
        }

        /// <summary>
        /// Test for deleting a tab stops online.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphTabStopOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var request = new DeleteParagraphTabStopOnlineRequest(
                document: requestDocument,
                position: 72.0f,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.DeleteParagraphTabStopOnline(request);
        }

        /// <summary>
        /// Test for deleting a tab stops without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteParagraphTabStopWithoutNodePath()
        {
            string remoteFileName = "TestDeleteParagraphTabStopWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new DeleteParagraphTabStopRequest(
                name: remoteFileName,
                position: 72.0f,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.DeleteParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(1, actual.TabStops.Count);
        }
    }
}
