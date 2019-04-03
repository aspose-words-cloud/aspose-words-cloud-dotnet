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

            var request = new GetParagraphRequest(remoteName, index, "sections/0", this.dataFolder);
            var actual = this.WordsApi.GetParagraph(request);
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

            var request = new GetParagraphRequest(remoteName, index, null, this.dataFolder);
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

            var request = new RenderParagraphRequest(remoteName, format, index, null, this.dataFolder);
            var actual = this.WordsApi.RenderParagraph(request);

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
            
            var request = new GetParagraphFormatRequest(remoteName, 0, null, this.dataFolder);
            var actual = this.WordsApi.GetParagraphFormat(request);
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
            
            var body = new ParagraphFormat
                           {
                               Alignment = ParagraphFormat.AlignmentEnum.Right
                           };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new UpdateParagraphFormatRequest(remoteName, body, string.Empty, 0, this.dataFolder);
            var actual = this.WordsApi.UpdateParagraphFormat(request);
        }
    }
}