// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FootnoteTest.cs">
// //   Copyright (c) 2017 Aspose.Words for Cloud
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

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to work with footnotes
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class FootnoteTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentElements/Footnote");

        private readonly string footnoteFolder = "Footnote/";

        /// <summary>
        /// Test for adding footnote
        /// </summary>
        [TestMethod]
        public void TestPutFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestPutFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var footNote = new Footnote { FootnoteType = Footnote.FootnoteTypeEnum.Endnote, Text = "test endnote" };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new PutFootnoteRequest(remoteName, footNote, this.dataFolder);
            var actual = this.WordsApi.PutFootnote(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting footnote
        /// </summary>
        [TestMethod]
        public void TestDeleteFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestDeleteFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new DeleteFootnoteRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.DeleteFootnote(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting footnotes
        /// </summary>
        [TestMethod]
        public void TestGetFootnotes()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnotes.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnotesRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetFootnotes(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting footnote
        /// </summary>
        [TestMethod]
        public void TestGetFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnoteRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.GetFootnote(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for updating footnote
        /// </summary>
        [TestMethod]
        public void TestPostFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestPostFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var footnote = new Footnote { Text = "new text is here" };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new PostFootnoteRequest(remoteName, footnote, index, this.dataFolder);
            var actual = this.WordsApi.PostFootnote(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}