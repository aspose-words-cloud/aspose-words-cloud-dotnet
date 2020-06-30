// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ParagraphTests.cs">
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
        private readonly string fieldFolder = "DocumentElements/Fields";
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
                nodePath: "sections/0",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraph(request);
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

            var request = new GetParagraphWithoutNodePathRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphWithoutNodePath(request);
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

            var request = new GetParagraphsWithoutNodePathRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphsWithoutNodePath(request);
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
                fontDto: new Font()
                {
                    Bold = true
                },
                paragraphPath: "paragraphs/0",
                index: 0,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );

            var actual = this.WordsApi.UpdateRunFont(request);
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

            var request = new InsertParagraphWithoutNodePathRequest(
                name: remoteFileName,
                paragraph: new ParagraphInsert()
                {
                    Text = "This is a new paragraph for your document"
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertParagraphWithoutNodePath(request);
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
                nodePath: null,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.RenderParagraph(request);
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

            var request = new RenderParagraphWithoutNodePathRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.RenderParagraphWithoutNodePath(request);
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
                nodePath: null,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphFormat(request);
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

            var request = new GetParagraphFormatWithoutNodePathRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphFormatWithoutNodePath(request);
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
                dto: new ParagraphFormat()
                {
                    Alignment = ParagraphFormat.AlignmentEnum.Right
                },
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateParagraphFormat(request);
        }

        /// <summary>
        /// Test for updating  paragraph format settings without node path.
        /// </summary>
        [Test]
        public void TestUpdateParagraphFormatWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentParagraphsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateParagraphFormatWithoutNodePathRequest(
                name: remoteFileName,
                dto: new ParagraphFormat()
                {
                    Alignment = ParagraphFormat.AlignmentEnum.Right
                },
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateParagraphFormatWithoutNodePath(request);
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
                nodePath: null,
                index: 0,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteParagraph(request);
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

            var request = new DeleteParagraphWithoutNodePathRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteParagraphWithoutNodePath(request);
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
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphListFormat(request);
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

            var request = new GetParagraphListFormatWithoutNodePathRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphListFormatWithoutNodePath(request);
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
                dto: new ListFormatUpdate()
                {
                    ListId = 2
                },
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateParagraphListFormat(request);
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

            var request = new UpdateParagraphListFormatWithoutNodePathRequest(
                name: remoteFileName,
                dto: new ListFormatUpdate()
                {
                    ListId = 2
                },
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateParagraphListFormatWithoutNodePath(request);
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
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.DeleteParagraphListFormat(request);
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

            var request = new DeleteParagraphListFormatWithoutNodePathRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.DeleteParagraphListFormatWithoutNodePath(request);
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
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphTabStops(request);
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

            var request = new GetParagraphTabStopsWithoutNodePathRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetParagraphTabStopsWithoutNodePath(request);
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
                dto: new TabStopInsert()
                {
                    Alignment = TabStopInsert.AlignmentEnum.Left,
                    Leader = TabStopInsert.LeaderEnum.None,
                    Position = 72f
                },
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertOrUpdateParagraphTabStop(request);
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

            var request = new InsertOrUpdateParagraphTabStopWithoutNodePathRequest(
                name: remoteFileName,
                dto: new TabStopInsert()
                {
                    Alignment = TabStopInsert.AlignmentEnum.Left,
                    Leader = TabStopInsert.LeaderEnum.None,
                    Position = 72f
                },
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertOrUpdateParagraphTabStopWithoutNodePath(request);
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
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.DeleteAllParagraphTabStops(request);
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

            var request = new DeleteAllParagraphTabStopsWithoutNodePathRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.DeleteAllParagraphTabStopsWithoutNodePath(request);
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
                position: 72f,
                nodePath: "",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.DeleteParagraphTabStop(request);
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

            var request = new DeleteParagraphTabStopWithoutNodePathRequest(
                name: remoteFileName,
                position: 72f,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.DeleteParagraphTabStopWithoutNodePath(request);
        }
    }
}
