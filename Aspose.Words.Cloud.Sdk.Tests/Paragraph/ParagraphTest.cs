// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ParagraphTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.Paragraph
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with paragraph
    /// </summary>
    [TestFixture]
    public class ParagraphTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Paragraphs");

        private readonly string fieldFolder = "DocumentElements/Fields/";
        private readonly string listFolder = "DocumentElements/ParagraphListFormat/";
        private readonly string tabStopFolder = "DocumentElements/Paragraphs/";

        /// <summary>
        /// Test for getting paragraph
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphByIndex()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphByIndex.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetParagraphRequest(remoteName, "sections/0", index, this.dataFolder);
            var actual = this.WordsApi.GetParagraph(request);
        }

        /// <summary>
        /// Test for getting paragraph without node path
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphByIndexWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphByIndexWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetParagraphWithoutNodePathRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.GetParagraphWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting all paragraphs
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphs()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphs.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetParagraphsRequest(remoteName, "sections/0", this.dataFolder);
            var actual = this.WordsApi.GetParagraphs(request);
        }

        /// <summary>
        /// Test for getting all paragraphs without node path
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphsWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphsWithoutNodePathWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetParagraphsWithoutNodePathRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetParagraphsWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting first paragraph
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetParagraphRequest(remoteName, null, index, this.dataFolder);
            var actual = this.WordsApi.GetParagraph(request);
        }

        /// <summary>
        /// Test for getting paragraph run
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRun()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphRun.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var runIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetRunRequest(remoteName, "paragraphs/0", runIndex, this.dataFolder);
            var actual = this.WordsApi.GetRun(request);
        }

        /// <summary>
        /// Test for getting paragraph run font
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRunFont()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphRunFont.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var runIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetRunFontRequest(remoteName, "paragraphs/0", runIndex, this.dataFolder);
            var actual = this.WordsApi.GetRunFont(request);
        }

        /// <summary>
        /// Test for getting paragraph run
        /// </summary>
        [Test]
        public void TestGetParagraphRuns()
        {
            var localName = "GetField.docx";
            var remoteName = "TestGetParagraphRuns.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetRunsRequest(remoteName, "sections/0/paragraphs/0", this.dataFolder);
            RunsResponse actual = this.WordsApi.GetRuns(request);
        }

        /// <summary>
        /// Test for updating paragraph run font
        /// </summary>
        [Test]
        public void TestUpdateRunFont()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestUpdateRunFont.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var runIndex = 0;
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var fontDto = new Font { Bold = true };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new UpdateRunFontRequest(remoteName, fontDto, "paragraphs/0", runIndex, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.UpdateRunFont(request);
        }

        /// <summary>
        /// Test for adding paragraph
        /// </summary>
        [Test]
        public void TestInsertParagraph()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestInsertParagraph.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var paragraph = new ParagraphInsert { Text = "This is a new paragraph for your document" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new InsertParagraphRequest(remoteName, paragraph, "sections/0", this.dataFolder);
            var actual = this.WordsApi.InsertParagraph(request);
        }

        /// <summary>
        /// Test for adding paragraph without node path
        /// </summary>
        [Test]
        public void TestInsertParagraphWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestInsertParagraphWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var paragraph = new ParagraphInsert { Text = "This is a new paragraph for your document" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new InsertParagraphWithoutNodePathRequest(remoteName, paragraph, this.dataFolder);
            var actual = this.WordsApi.InsertParagraphWithoutNodePath(request);
        }

        /// <summary>
        /// Test for paragraph rendering
        /// </summary>
        [Test]
        public void TestRenderParagraph()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestRenderParagraph.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var format = "png";
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new RenderParagraphRequest(remoteName, format, null, index, this.dataFolder);
            var actual = this.WordsApi.RenderParagraph(request);

            Assert.IsTrue(actual.Length > 0, "Error has occurred while paragraph rendering");
        }

        /// <summary>
        /// Test for paragraph rendering without node path
        /// </summary>
        [Test]
        public void TestRenderParagraphWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestRenderParagraphWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var format = "png";
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new RenderParagraphWithoutNodePathRequest(remoteName, format, index, this.dataFolder);
            var actual = this.WordsApi.RenderParagraphWithoutNodePath(request);

            Assert.IsTrue(actual.Length > 0, "Error has occurred while paragraph rendering");
        }

        /// <summary>
        /// Test for getting paragraph format settings
        /// </summary>
        [Test]
        public void TestGetParagraphFormat()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphs.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));
            
            var request = new GetParagraphFormatRequest(remoteName, null, 0, this.dataFolder);
            var actual = this.WordsApi.GetParagraphFormat(request);
        }

        /// <summary>
        /// Test for getting paragraph format settings without node path
        /// </summary>
        [Test]
        public void TestGetParagraphFormatWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphsWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetParagraphFormatWithoutNodePathRequest(remoteName, 0, this.dataFolder);
            var actual = this.WordsApi.GetParagraphFormatWithoutNodePath(request);
        }

        /// <summary>
        /// Test for updating  paragraph format settings
        /// </summary>
        [Test]
        public void TestUpdateParagraphFormat()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphs.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            
            var body = new ParagraphFormatUpdate
                           {
                               Alignment = ParagraphFormat.AlignmentEnum.Right
                           };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new UpdateParagraphFormatRequest(remoteName, body, string.Empty, 0, this.dataFolder);
            var actual = this.WordsApi.UpdateParagraphFormat(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph 
        /// </summary>
        [Test]
        public void TestDeleteParagraph()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphs.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteParagraphRequest(remoteName, null, 0, this.dataFolder);
            this.WordsApi.DeleteParagraph(request);
        }

        /// <summary>
        /// Test for deleting  a paragraph without node path
        /// </summary>
        [Test]
        public void TestDeleteParagraphWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphsWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteParagraphWithoutNodePathRequest(remoteName, 0, this.dataFolder);
            this.WordsApi.DeleteParagraphWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting paragraph list format
        /// </summary>
        [Test]
        public void TestGetParagraphListFormat()
        {
            var name = "ParagraphGetListFormat.doc";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, listFolder, name);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(listFolder) + name));

            var request = new GetParagraphListFormatRequest(name, "", index, Path.Combine(RemoteBaseTestDataFolder, listFolder));
            var actual = this.WordsApi.GetParagraphListFormat(request);
        }

        /// <summary>
        /// Test for getting paragraph list format
        /// </summary>
        [Test]
        public void TestGetParagraphListFormatWithoutNodePath()
        {
            var name = "ParagraphGetListFormat.doc";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, listFolder, name);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(listFolder) + name));

            var request = new GetParagraphListFormatWithoutNodePathRequest(name, index, Path.Combine(RemoteBaseTestDataFolder, listFolder));
            var actual = this.WordsApi.GetParagraphListFormatWithoutNodePath(request);
        }

        /// <summary>
        /// Test for updating paragraph list format
        /// </summary>
        [Test]
        public void TestUpdateParagraphListFormat()
        {
            var name = "ParagraphUpdateListFormat.doc";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, listFolder, name);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(listFolder) + name));

            var dto = new ListFormatUpdate();
            dto.ListId = 2;

            var request = new UpdateParagraphListFormatRequest(name, dto, "", index, Path.Combine(RemoteBaseTestDataFolder, listFolder));
            var actual = this.WordsApi.UpdateParagraphListFormat(request);
        }

        /// <summary>
        /// Test for updating paragraph list format without node path
        /// </summary>
        [Test]
        public void TestUpdateParagraphListFormatWithoutNodePath()
        {
            var name = "ParagraphUpdateListFormat.doc";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, listFolder, name);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(listFolder) + name));

            var dto = new ListFormatUpdate();
            dto.ListId = 2;

            var request = new UpdateParagraphListFormatWithoutNodePathRequest(name, dto, index, Path.Combine(RemoteBaseTestDataFolder, listFolder));
            var actual = this.WordsApi.UpdateParagraphListFormatWithoutNodePath(request);
        }

        /// <summary>
        /// Test for deleting paragraph list format
        /// </summary>
        [Test]
        public void TestDeleteParagraphListFormat()
        {
            var name = "ParagraphDeleteListFormat.doc";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, listFolder, name);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(listFolder) + name));

            var request = new DeleteParagraphListFormatRequest(name, "", index, Path.Combine(RemoteBaseTestDataFolder, listFolder));
            var actual = this.WordsApi.DeleteParagraphListFormat(request);
        }

        /// <summary>
        /// Test for deleting paragraph list format without node path
        /// </summary>
        [Test]
        public void TestDeleteParagraphListFormatWithoutNodePath()
        {
            var name = "ParagraphDeleteListFormat.doc";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, listFolder, name);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(listFolder) + name));

            var request = new DeleteParagraphListFormatWithoutNodePathRequest(name, index, Path.Combine(RemoteBaseTestDataFolder, listFolder));
            var actual = this.WordsApi.DeleteParagraphListFormatWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting paragraph tab stops
        /// </summary>
        [Test]
        public void TestGetParagraphTabStops()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var request = new GetParagraphTabStopsRequest(name, "", 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.GetParagraphTabStops(request);
        }

        /// <summary>
        /// Test for getting paragraph tab stops without node path
        /// </summary>
        [Test]
        public void TestGetParagraphTabStopsWithoutNodePath()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var request = new GetParagraphTabStopsWithoutNodePathRequest(name, 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.GetParagraphTabStopsWithoutNodePath(request);
        }

        /// <summary>
        /// Test for inserting paragraph tab stop
        /// </summary>
        [Test]
        public void TestInsertParagraphTabStops()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var dto = new TabStopInsert
            {
                Alignment = TabStopBase.AlignmentEnum.Left,
                Leader = TabStopBase.LeaderEnum.None,
                Position = 72,
            };

            var request = new InsertOrUpdateParagraphTabStopRequest(name, dto, "", 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.InsertOrUpdateParagraphTabStop(request);
        }

        /// <summary>
        /// Test for inserting paragraph tab stop without node path
        /// </summary>
        [Test]
        public void TestInsertParagraphTabStopWithoutNodePath()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var dto = new TabStopInsert
            {
                Alignment = TabStopBase.AlignmentEnum.Left,
                Leader = TabStopBase.LeaderEnum.None,
                Position = 72,
            };

            var request = new InsertOrUpdateParagraphTabStopWithoutNodePathRequest(name, dto, 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.InsertOrUpdateParagraphTabStopWithoutNodePath(request);
        }

        /// <summary>
        /// Test for deleting all paragraph tab stops
        /// </summary>
        [Test]
        public void TestDeleteAllParagraphTabStops()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var request = new DeleteAllParagraphTabStopsRequest(name, "", 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.DeleteAllParagraphTabStops(request);
        }

        /// <summary>
        /// Test for deleting all paragraph tab stops without node path
        /// </summary>
        [Test]
        public void TestDeleteAllParagraphTabStopsWithoutNodePath()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var request = new DeleteAllParagraphTabStopsWithoutNodePathRequest(name, 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.DeleteAllParagraphTabStopsWithoutNodePath(request);
        }

        /// <summary>
        /// Test for deleting a tab stops
        /// </summary>
        [Test]
        public void TestDeleteParagraphTabStop()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var request = new DeleteParagraphTabStopRequest(name, 72, "", 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.DeleteParagraphTabStop(request);
        }

        /// <summary>
        /// Test for deleting a tab stop without node path
        /// </summary>
        [Test]
        public void TestDeleteParagraphTabStopWithoutNodePath()
        {
            var name = "ParagraphTabStops.docx";
            var fullName = Path.Combine(RemoteBaseTestDataFolder, tabStopFolder, name);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(tabStopFolder) + name));

            var request = new DeleteParagraphTabStopWithoutNodePathRequest(name, 72, 0, folder: Path.Combine(RemoteBaseTestDataFolder, tabStopFolder));
            var actual = this.WordsApi.DeleteParagraphTabStopWithoutNodePath(request);
        }
    }
}