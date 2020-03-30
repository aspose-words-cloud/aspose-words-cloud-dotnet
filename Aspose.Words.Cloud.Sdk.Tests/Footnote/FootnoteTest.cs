// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FootnoteTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.Footnote
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with footnotes
    /// </summary>
    [TestFixture]
    public class FootnoteTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Footnotes");

        private readonly string footnoteFolder = "DocumentElements/Footnotes/";

        /// <summary>
        /// Test for adding footnote
        /// </summary>
        [Test]
        public void TestInsertFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestInsertFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var footNote = new FootnoteInsert { FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote, Text = "test endnote" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new InsertFootnoteRequest(remoteName, footNote, null, this.dataFolder);
            var actual = this.WordsApi.InsertFootnote(request);
        }

        /// <summary>
        /// Test for adding footnote without node path
        /// </summary>
        [Test]
        public void TestInsertFootnoteWithoutNodePath()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestInsertFootnoteWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var footNote = new FootnoteInsert { FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote, Text = "test endnote" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new InsertFootnoteWithoutNodePathRequest(remoteName, footNote, this.dataFolder);
            var actual = this.WordsApi.InsertFootnoteWithoutNodePath(request);
        }

        /// <summary>
        /// Test for deleting footnote
        /// </summary>
        [Test]
        public void TestDeleteFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestDeleteFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new DeleteFootnoteRequest(remoteName, null, index, this.dataFolder);
            this.WordsApi.DeleteFootnote(request);
        }

        /// <summary>
        /// Test for deleting footnote without node path
        /// </summary>
        [Test]
        public void TestDeleteFootnoteWithoutNodePath()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestDeleteFootnoteWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new DeleteFootnoteWithoutNodePathRequest(remoteName, index, this.dataFolder);
            this.WordsApi.DeleteFootnoteWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting footnotes
        /// </summary>
        [Test]
        public void TestGetFootnotes()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnotes.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnotesRequest(remoteName, null, this.dataFolder);
            var actual = this.WordsApi.GetFootnotes(request);
        }

        /// <summary>
        /// Test for getting footnotes without node path
        /// </summary>
        [Test]
        public void TestGetFootnotesWithoutNodePath()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnotesWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnotesWithoutNodePathRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetFootnotesWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting footnote
        /// </summary>
        [Test]
        public void TestGetFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnoteRequest(remoteName, null, index, this.dataFolder);
            var actual = this.WordsApi.GetFootnote(request);
        }

        /// <summary>
        /// Test for getting footnote without node path
        /// </summary>
        [Test]
        public void TestGetFootnoteWithoutNodePath()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnoteWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnoteWithoutNodePathRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.GetFootnoteWithoutNodePath(request);
        }

        /// <summary>
        /// Test for updating footnote
        /// </summary>
        [Test]
        public void TestUpdateFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestUpdateFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var footnote = new FootnoteUpdate { Text = "new text is here" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new UpdateFootnoteRequest(remoteName, footnote, null, index, this.dataFolder);
            var actual = this.WordsApi.UpdateFootnote(request);
        }

        /// <summary>
        /// Test for updating footnote without node path
        /// </summary>
        [Test]
        public void TestUpdateFootnoteWithoutNodePath()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestUpdateFootnoteWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var footnote = new FootnoteUpdate { Text = "new text is here" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new UpdateFootnoteWithoutNodePathRequest(remoteName, footnote, index, this.dataFolder);
            var actual = this.WordsApi.UpdateFootnoteWithoutNodePath(request);
        }
    }
}