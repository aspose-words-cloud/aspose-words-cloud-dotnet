// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FootnoteTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Footnote
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with footnotes.
    /// </summary>
    [TestFixture]
    public class FootnoteTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Footnotes";
        private readonly string footnoteFolder = "DocumentElements/Footnotes";

        /// <summary>
        /// Test for adding footnote.
        /// </summary>
        [Test]
        public void TestInsertFootnote()
        {
            string remoteFileName = "TestInsertFootnote.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new InsertFootnoteRequest(
                name: remoteFileName,
                footnoteDto: new FootnoteInsert()
                {
                    FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
                    Text = "test endnote"
                },
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual("0.1.7.1", actual.Footnote.NodeId);
            Assert.AreEqual(" test endnote" + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for adding footnote online.
        /// </summary>
        [Test]
        public void TestInsertFootnoteOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new InsertFootnoteOnlineRequest(
                document: documentStream,
                footnoteDto: new FootnoteInsert()
                {
                    FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
                    Text = "test endnote"
                },
                nodePath: ""
            );
            var actual = this.WordsApi.InsertFootnoteOnline(request);
        }

        /// <summary>
        /// Test for adding footnote without node path.
        /// </summary>
        [Test]
        public void TestInsertFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestInsertFootnoteWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new InsertFootnoteRequest(
                name: remoteFileName,
                footnoteDto: new FootnoteInsert()
                {
                    FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
                    Text = "test endnote"
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual("0.1.7.1", actual.Footnote.NodeId);
            Assert.AreEqual(" test endnote" + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for deleting footnote.
        /// </summary>
        [Test]
        public void TestDeleteFootnote()
        {
            string remoteFileName = "TestDeleteFootnote.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new DeleteFootnoteRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
        this.WordsApi.DeleteFootnote(request);
        }

        /// <summary>
        /// Test for deleting footnote online.
        /// </summary>
        [Test]
        public void TestDeleteFootnoteOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new DeleteFootnoteOnlineRequest(
                document: documentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.DeleteFootnoteOnline(request);
        }

        /// <summary>
        /// Test for deleting footnote without node path.
        /// </summary>
        [Test]
        public void TestDeleteFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestDeleteFootnoteWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new DeleteFootnoteRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
        this.WordsApi.DeleteFootnote(request);
        }

        /// <summary>
        /// Test for getting footnotes.
        /// </summary>
        [Test]
        public void TestGetFootnotes()
        {
            string remoteFileName = "TestGetFootnotes.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new GetFootnotesRequest(
                name: remoteFileName,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetFootnotes(request);
            Assert.NotNull(actual.Footnotes);
            Assert.NotNull(actual.Footnotes.List);
            Assert.AreEqual(6, actual.Footnotes.List.Count);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnotes.List[0].Text);
        }

        /// <summary>
        /// Test for getting footnotes online.
        /// </summary>
        [Test]
        public void TestGetFootnotesOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new GetFootnotesOnlineRequest(
                document: documentStream,
                nodePath: ""
            );
            var actual = this.WordsApi.GetFootnotesOnline(request);
        }

        /// <summary>
        /// Test for getting footnotes without node path.
        /// </summary>
        [Test]
        public void TestGetFootnotesWithoutNodePath()
        {
            string remoteFileName = "TestGetFootnotesWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new GetFootnotesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetFootnotes(request);
            Assert.NotNull(actual.Footnotes);
            Assert.NotNull(actual.Footnotes.List);
            Assert.AreEqual(6, actual.Footnotes.List.Count);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnotes.List[0].Text);
        }

        /// <summary>
        /// Test for getting footnote.
        /// </summary>
        [Test]
        public void TestGetFootnote()
        {
            string remoteFileName = "TestGetFootnote.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new GetFootnoteRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for getting footnote online.
        /// </summary>
        [Test]
        public void TestGetFootnoteOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new GetFootnoteOnlineRequest(
                document: documentStream,
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.GetFootnoteOnline(request);
        }

        /// <summary>
        /// Test for getting footnote without node path.
        /// </summary>
        [Test]
        public void TestGetFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestGetFootnoteWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new GetFootnoteRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for updating footnote.
        /// </summary>
        [Test]
        public void TestUpdateFootnote()
        {
            string remoteFileName = "TestUpdateFootnote.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new UpdateFootnoteRequest(
                name: remoteFileName,
                index: 0,
                footnoteDto: new FootnoteUpdate()
                {
                    Text = "new text is here"
                },
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" new text is here" + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for updating footnote online.
        /// </summary>
        [Test]
        public void TestUpdateFootnoteOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new UpdateFootnoteOnlineRequest(
                document: documentStream,
                footnoteDto: new FootnoteUpdate()
                {
                    Text = "new text is here"
                },
                index: 0,
                nodePath: ""
            );
            var actual = this.WordsApi.UpdateFootnoteOnline(request);
        }

        /// <summary>
        /// Test for updating footnote without node path.
        /// </summary>
        [Test]
        public void TestUpdateFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestUpdateFootnoteWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new UpdateFootnoteRequest(
                name: remoteFileName,
                index: 0,
                footnoteDto: new FootnoteUpdate()
                {
                    Text = "new text is here"
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" new text is here" + "\r\n", actual.Footnote.Text);
        }
    }
}
