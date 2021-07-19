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
        public void TestGetDocumentParagraphByIndex()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndex.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.0.0", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for getting paragraph online.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetParagraphOnlineRequest(
                document: requestDocumentStream,
                index: 0,
                nodePath: "sections/0"
            );
            var actual = this.WordsApi.GetParagraphOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph without node path.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphByIndexWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndexWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.0.0", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for getting all paragraphs.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphs()
        {
            string remoteFileName = "TestGetDocumentParagraphs.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraphs(request);
            Assert.NotNull(actual.Paragraphs);
            Assert.NotNull(actual.Paragraphs.ParagraphLinkList);
            Assert.AreEqual(15, actual.Paragraphs.ParagraphLinkList.Count);
            Assert.AreEqual("Page 1 of 3", actual.Paragraphs.ParagraphLinkList[0].Text);
        }

        /// <summary>
        /// Test for getting all paragraphs online.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphsOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetParagraphsOnlineRequest(
                document: requestDocumentStream,
                nodePath: "sections/0"
            );
            var actual = this.WordsApi.GetParagraphsOnline(request);
        }

        /// <summary>
        /// Test for getting all paragraphs without node path.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphsWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentParagraphsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetParagraphsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetParagraphs(request);
            Assert.NotNull(actual.Paragraphs);
            Assert.NotNull(actual.Paragraphs.ParagraphLinkList);
            Assert.AreEqual(15, actual.Paragraphs.ParagraphLinkList.Count);
            Assert.AreEqual("Page 1 of 3", actual.Paragraphs.ParagraphLinkList[0].Text);
        }

        /// <summary>
        /// Test for getting paragraph run.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRun()
        {
            string remoteFileName = "TestGetDocumentParagraphRun.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetRun(request);
            Assert.NotNull(actual.Run);
            Assert.AreEqual("Page ", actual.Run.Text);
        }

        /// <summary>
        /// Test for getting paragraph run online.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRunOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetRunOnlineRequest(
                document: requestDocumentStream,
                paragraphPath: "paragraphs/0",
                index: 0
            );
            var actual = this.WordsApi.GetRunOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph run font.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRunFont()
        {
            string remoteFileName = "TestGetDocumentParagraphRunFont.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetRunFont(request);
            Assert.NotNull(actual.Font);
            Assert.AreEqual("Times New Roman", actual.Font.Name);
        }

        /// <summary>
        /// Test for getting paragraph run font online.
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRunFontOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetRunFontOnlineRequest(
                document: requestDocumentStream,
                paragraphPath: "paragraphs/0",
                index: 0
            );
            var actual = this.WordsApi.GetRunFontOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph runs.
        /// </summary>
        [Test]
        public void TestGetParagraphRuns()
        {
            string remoteFileName = "TestGetParagraphRuns.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetRuns(request);
            Assert.NotNull(actual.Runs);
            Assert.NotNull(actual.Runs.List);
            Assert.AreEqual(6, actual.Runs.List.Count);
            Assert.AreEqual("Page ", actual.Runs.List[0].Text);
        }

        /// <summary>
        /// Test for getting paragraph runs online.
        /// </summary>
        [Test]
        public void TestGetParagraphRunsOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetRunsOnlineRequest(
                document: requestDocumentStream,
                paragraphPath: "sections/0/paragraphs/0"
            );
            var actual = this.WordsApi.GetRunsOnline(request);
        }

        /// <summary>
        /// Test for updating paragraph run font.
        /// </summary>
        [Test]
        public void TestUpdateRunFont()
        {
            string remoteFileName = "TestUpdateRunFont.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateRunFontRequest(
                name: remoteFileName,
                paragraphPath: "paragraphs/0",
                index: 0,
                fontDto: new Font()
                {
                    Bold = true
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.UpdateRunFont(request);
            Assert.NotNull(actual.Font);
            Assert.AreEqual(true, actual.Font.Bold);
        }

        /// <summary>
        /// Test for updating paragraph run font online.
        /// </summary>
        [Test]
        public void TestUpdateRunFontOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateRunFontOnlineRequest(
                document: requestDocumentStream,
                paragraphPath: "paragraphs/0",
                fontDto: new Font()
                {
                    Bold = true
                },
                index: 0
            );
            var actual = this.WordsApi.UpdateRunFontOnline(request);
        }

        /// <summary>
        /// Test for adding paragraph.
        /// </summary>
        [Test]
        public void TestInsertParagraph()
        {
            string remoteFileName = "TestInsertParagraph.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertParagraphRequest(
                name: remoteFileName,
                paragraph: new ParagraphInsert()
                {
                    Text = "This is a new paragraph for your document"
                },
                nodePath: "sections/0",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.3.8", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for adding paragraph online.
        /// </summary>
        [Test]
        public void TestInsertParagraphOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertParagraphOnlineRequest(
                document: requestDocumentStream,
                paragraph: new ParagraphInsert()
                {
                    Text = "This is a new paragraph for your document"
                },
                nodePath: "sections/0"
            );
            var actual = this.WordsApi.InsertParagraphOnline(request);
        }

        /// <summary>
        /// Test for adding paragraph without node path.
        /// </summary>
        [Test]
        public void TestInsertParagraphWithoutNodePath()
        {
            string remoteFileName = "TestInsertParagraphWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertParagraphRequest(
                name: remoteFileName,
                paragraph: new ParagraphInsert()
                {
                    Text = "This is a new paragraph for your document"
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertParagraph(request);
            Assert.NotNull(actual.Paragraph);
            Assert.AreEqual("0.3.8", actual.Paragraph.NodeId);
        }

        /// <summary>
        /// Test for paragraph rendering.
        /// </summary>
        [Test]
        public void TestRenderParagraph()
        {
            string remoteFileName = "TestRenderParagraph.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.RenderParagraph(request);
        }

        /// <summary>
        /// Test for paragraph rendering.
        /// </summary>
        [Test]
        public void TestRenderParagraphOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new RenderParagraphOnlineRequest(
                document: requestDocumentStream,
                format: "png",
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.RenderParagraphOnline(request);
        }

        /// <summary>
        /// Test for paragraph rendering without node path.
        /// </summary>
        [Test]
        public void TestRenderParagraphWithoutNodePath()
        {
            string remoteFileName = "TestRenderParagraphWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.RenderParagraph(request);
        }

        /// <summary>
        /// Test for getting paragraph format settings.
        /// </summary>
        [Test]
        public void TestGetParagraphFormat()
        {
            string remoteFileName = "TestGetDocumentParagraphs.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraphFormat(request);
            Assert.NotNull(actual.ParagraphFormat);
            Assert.AreEqual("Normal", actual.ParagraphFormat.StyleName);
        }

        /// <summary>
        /// Test for getting paragraph format settings online.
        /// </summary>
        [Test]
        public void TestGetParagraphFormatOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetParagraphFormatOnlineRequest(
                document: requestDocumentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.GetParagraphFormatOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph format settings without node path.
        /// </summary>
        [Test]
        public void TestGetParagraphFormatWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentParagraphsWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraphFormat(request);
            Assert.NotNull(actual.ParagraphFormat);
            Assert.AreEqual("Normal", actual.ParagraphFormat.StyleName);
        }

        /// <summary>
        /// Test for updating  paragraph format settings.
        /// </summary>
        [Test]
        public void TestUpdateParagraphFormat()
        {
            string remoteFileName = "TestGetDocumentParagraphs.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateParagraphFormatRequest(
                name: remoteFileName,
                index: 0,
                paragraphFormatDto: new ParagraphFormatUpdate()
                {
                    Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
                },
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateParagraphFormat(request);
            Assert.NotNull(actual.ParagraphFormat);

        }

        /// <summary>
        /// Test for updating  paragraph format settings online.
        /// </summary>
        [Test]
        public void TestUpdateParagraphFormatOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateParagraphFormatOnlineRequest(
                document: requestDocumentStream,
                paragraphFormatDto: new ParagraphFormatUpdate()
                {
                    Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
                },
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.UpdateParagraphFormatOnline(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph.
        /// </summary>
        [Test]
        public void TestDeleteParagraph()
        {
            string remoteFileName = "TestDeleteParagraph.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteParagraph(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph online.
        /// </summary>
        [Test]
        public void TestDeleteParagraphOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteParagraphOnlineRequest(
                document: requestDocumentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.DeleteParagraphOnline(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph without node path.
        /// </summary>
        [Test]
        public void TestDeleteParagraphWithoutNodePath()
        {
            string remoteFileName = "TestDeleteParagraphWithoutNodePath.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteParagraph(request);
        }

        /// <summary>
        /// Test for getting paragraph list format.
        /// </summary>
        [Test]
        public void TestGetParagraphListFormat()
        {
            string remoteFileName = "TestParagraphGetListFormat.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(1, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for getting paragraph list format online.
        /// </summary>
        [Test]
        public void TestGetParagraphListFormatOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + listFolder + "/ParagraphGetListFormat.doc");
            var request = new GetParagraphListFormatOnlineRequest(
                document: requestDocumentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.GetParagraphListFormatOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph list format without node path.
        /// </summary>
        [Test]
        public void TestGetParagraphListFormatWithoutNodePath()
        {
            string remoteFileName = "TestParagraphGetListFormatWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(1, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for updating paragraph list format.
        /// </summary>
        [Test]
        public void TestUpdateParagraphListFormat()
        {
            string remoteFileName = "TestUpdateParagraphListFormat.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphUpdateListFormat.doc")
            );

            var request = new UpdateParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                listFormatDto: new ListFormatUpdate()
                {
                    ListId = 2
                },
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(2, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for updating paragraph list format online.
        /// </summary>
        [Test]
        public void TestUpdateParagraphListFormatOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + listFolder + "/ParagraphUpdateListFormat.doc");
            var request = new UpdateParagraphListFormatOnlineRequest(
                document: requestDocumentStream,
                listFormatDto: new ListFormatUpdate()
                {
                    ListId = 2
                },
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.UpdateParagraphListFormatOnline(request);
        }

        /// <summary>
        /// Test for updating paragraph list format without node path.
        /// </summary>
        [Test]
        public void TestUpdateParagraphListFormatWithoutNodePath()
        {
            string remoteFileName = "TestUpdateParagraphListFormatWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + listFolder + "/ParagraphUpdateListFormat.doc")
            );

            var request = new UpdateParagraphListFormatRequest(
                name: remoteFileName,
                index: 0,
                listFormatDto: new ListFormatUpdate()
                {
                    ListId = 2
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateParagraphListFormat(request);
            Assert.NotNull(actual.ListFormat);
            Assert.AreEqual(2, actual.ListFormat.ListId);
        }

        /// <summary>
        /// Test for deleting paragraph list format.
        /// </summary>
        [Test]
        public void TestDeleteParagraphListFormat()
        {
            string remoteFileName = "TestDeleteParagraphListFormat.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.DeleteParagraphListFormat(request);
        }

        /// <summary>
        /// Test for deleting paragraph list format online.
        /// </summary>
        [Test]
        public void TestDeleteParagraphListFormatOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + listFolder + "/ParagraphDeleteListFormat.doc");
            var request = new DeleteParagraphListFormatOnlineRequest(
                document: requestDocumentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.DeleteParagraphListFormatOnline(request);
        }

        /// <summary>
        /// Test for deleting paragraph list format without node path.
        /// </summary>
        [Test]
        public void TestDeleteParagraphListFormatWithoutNodePath()
        {
            string remoteFileName = "TestDeleteParagraphListFormatWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.DeleteParagraphListFormat(request);
        }

        /// <summary>
        /// Test for getting paragraph tab stops.
        /// </summary>
        [Test]
        public void TestGetParagraphTabStops()
        {
            string remoteFileName = "TestGetParagraphTabStops.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(2, actual.TabStops.Count);
            Assert.AreEqual(72.0f, actual.TabStops[0].Position);
        }

        /// <summary>
        /// Test for getting paragraph tab stops online.
        /// </summary>
        [Test]
        public void TestGetParagraphTabStopsOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var request = new GetParagraphTabStopsOnlineRequest(
                document: requestDocumentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.GetParagraphTabStopsOnline(request);
        }

        /// <summary>
        /// Test for getting paragraph tab stops without node path.
        /// </summary>
        [Test]
        public void TestGetParagraphTabStopsWithoutNodePath()
        {
            string remoteFileName = "TestGetParagraphTabStopsWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(2, actual.TabStops.Count);
            Assert.AreEqual(72.0f, actual.TabStops[0].Position);
        }

        /// <summary>
        /// Test for inserting paragraph tab stop.
        /// </summary>
        [Test]
        public void TestInsertParagraphTabStops()
        {
            string remoteFileName = "TestInsertOrUpdateParagraphTabStop.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new InsertOrUpdateParagraphTabStopRequest(
                name: remoteFileName,
                index: 0,
                tabStopInsertDto: new TabStopInsert()
                {
                    Alignment = TabStopInsert.AlignmentEnum.Left,
                    Leader = TabStopInsert.LeaderEnum.None,
                    Position = 100.0f
                },
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertOrUpdateParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(3, actual.TabStops.Count);
            Assert.AreEqual(100.0f, actual.TabStops[1].Position);


        }

        /// <summary>
        /// Test for inserting paragraph tab stop online.
        /// </summary>
        [Test]
        public void TestInsertParagraphTabStopsOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var request = new InsertOrUpdateParagraphTabStopOnlineRequest(
                document: requestDocumentStream,
                tabStopInsertDto: new TabStopInsert()
                {
                    Alignment = TabStopInsert.AlignmentEnum.Left,
                    Leader = TabStopInsert.LeaderEnum.None,
                    Position = 72f
                },
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.InsertOrUpdateParagraphTabStopOnline(request);
        }

        /// <summary>
        /// Test for inserting paragraph tab stop without node path.
        /// </summary>
        [Test]
        public void TestInsertParagraphTabStopsWithoutNodePath()
        {
            string remoteFileName = "TestInsertOrUpdateParagraphTabStopWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx")
            );

            var request = new InsertOrUpdateParagraphTabStopRequest(
                name: remoteFileName,
                index: 0,
                tabStopInsertDto: new TabStopInsert()
                {
                    Alignment = TabStopInsert.AlignmentEnum.Left,
                    Leader = TabStopInsert.LeaderEnum.None,
                    Position = 100.0f
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertOrUpdateParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(3, actual.TabStops.Count);
            Assert.AreEqual(100.0f, actual.TabStops[1].Position);


        }

        /// <summary>
        /// Test for deleting all paragraph tab stops.
        /// </summary>
        [Test]
        public void TestDeleteAllParagraphTabStops()
        {
            string remoteFileName = "TestDeleteAllParagraphTabStops.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.DeleteAllParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(0, actual.TabStops.Count);
        }

        /// <summary>
        /// Test for deleting all paragraph tab stops online.
        /// </summary>
        [Test]
        public void TestDeleteAllParagraphTabStopsOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var request = new DeleteAllParagraphTabStopsOnlineRequest(
                document: requestDocumentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.DeleteAllParagraphTabStopsOnline(request);
        }

        /// <summary>
        /// Test for deleting all paragraph tab stops without node path.
        /// </summary>
        [Test]
        public void TestDeleteAllParagraphTabStopsWithoutNodePath()
        {
            string remoteFileName = "TestDeleteAllParagraphTabStopsWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.DeleteAllParagraphTabStops(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(0, actual.TabStops.Count);
        }

        /// <summary>
        /// Test for deleting a tab stops.
        /// </summary>
        [Test]
        public void TestDeleteParagraphTabStop()
        {
            string remoteFileName = "TestDeleteParagraphTabStop.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.DeleteParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(1, actual.TabStops.Count);
        }

        /// <summary>
        /// Test for deleting a tab stops online.
        /// </summary>
        [Test]
        public void TestDeleteParagraphTabStopOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + tabStopFolder + "/ParagraphTabStops.docx");
            var request = new DeleteParagraphTabStopOnlineRequest(
                document: requestDocumentStream,
                position: 72.0f,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.DeleteParagraphTabStopOnline(request);
        }

        /// <summary>
        /// Test for deleting a tab stops without node path.
        /// </summary>
        [Test]
        public void TestDeleteParagraphTabStopWithoutNodePath()
        {
            string remoteFileName = "TestDeleteParagraphTabStopWithoutNodePath.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.DeleteParagraphTabStop(request);
            Assert.NotNull(actual.TabStops);
            Assert.AreEqual(1, actual.TabStops.Count);
        }
    }
}
