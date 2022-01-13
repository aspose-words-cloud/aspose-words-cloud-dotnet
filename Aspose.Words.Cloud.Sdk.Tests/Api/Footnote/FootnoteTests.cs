// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FootnoteTests.cs">
//   Copyright (c) 2022 Aspose.Words for Cloud
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
    using System.Threading.Tasks;
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
        public async Task TestInsertFootnote()
        {
            string remoteFileName = "TestInsertFootnote.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var requestFootnoteDto = new FootnoteInsert()
            {
                FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
                Text = "test endnote"
            };
            var request = new InsertFootnoteRequest(
                name: remoteFileName,
                footnoteDto: requestFootnoteDto,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual("0.1.7.1", actual.Footnote.NodeId);
            Assert.AreEqual(" test endnote" + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for adding footnote online.
        /// </summary>
        [Test]
        public async Task TestInsertFootnoteOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var requestFootnoteDto = new FootnoteInsert()
            {
                FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
                Text = "test endnote"
            };
            var request = new InsertFootnoteOnlineRequest(
                document: requestDocument,
                footnoteDto: requestFootnoteDto,
                nodePath: ""
            );
            var actual = await this.WordsApi.InsertFootnoteOnline(request);
        }

        /// <summary>
        /// Test for adding footnote without node path.
        /// </summary>
        [Test]
        public async Task TestInsertFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestInsertFootnoteWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var requestFootnoteDto = new FootnoteInsert()
            {
                FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
                Text = "test endnote"
            };
            var request = new InsertFootnoteRequest(
                name: remoteFileName,
                footnoteDto: requestFootnoteDto,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual("0.1.7.1", actual.Footnote.NodeId);
            Assert.AreEqual(" test endnote" + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for deleting footnote.
        /// </summary>
        [Test]
        public async Task TestDeleteFootnote()
        {
            string remoteFileName = "TestDeleteFootnote.docx";

            await this.UploadFileToStorage(
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
        await this.WordsApi.DeleteFootnote(request);
        }

        /// <summary>
        /// Test for deleting footnote online.
        /// </summary>
        [Test]
        public async Task TestDeleteFootnoteOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new DeleteFootnoteOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.DeleteFootnoteOnline(request);
        }

        /// <summary>
        /// Test for deleting footnote without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestDeleteFootnoteWithoutNodePath.docx";

            await this.UploadFileToStorage(
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
        await this.WordsApi.DeleteFootnote(request);
        }

        /// <summary>
        /// Test for getting footnotes.
        /// </summary>
        [Test]
        public async Task TestGetFootnotes()
        {
            string remoteFileName = "TestGetFootnotes.docx";

            await this.UploadFileToStorage(
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
            var actual = await this.WordsApi.GetFootnotes(request);
            Assert.NotNull(actual.Footnotes);
            Assert.NotNull(actual.Footnotes.List);
            Assert.AreEqual(6, actual.Footnotes.List.Count);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnotes.List[0].Text);
        }

        /// <summary>
        /// Test for getting footnotes online.
        /// </summary>
        [Test]
        public async Task TestGetFootnotesOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new GetFootnotesOnlineRequest(
                document: requestDocument,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetFootnotesOnline(request);
        }

        /// <summary>
        /// Test for getting footnotes without node path.
        /// </summary>
        [Test]
        public async Task TestGetFootnotesWithoutNodePath()
        {
            string remoteFileName = "TestGetFootnotesWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var request = new GetFootnotesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetFootnotes(request);
            Assert.NotNull(actual.Footnotes);
            Assert.NotNull(actual.Footnotes.List);
            Assert.AreEqual(6, actual.Footnotes.List.Count);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnotes.List[0].Text);
        }

        /// <summary>
        /// Test for getting footnote.
        /// </summary>
        [Test]
        public async Task TestGetFootnote()
        {
            string remoteFileName = "TestGetFootnote.docx";

            await this.UploadFileToStorage(
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
            var actual = await this.WordsApi.GetFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for getting footnote online.
        /// </summary>
        [Test]
        public async Task TestGetFootnoteOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var request = new GetFootnoteOnlineRequest(
                document: requestDocument,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetFootnoteOnline(request);
        }

        /// <summary>
        /// Test for getting footnote without node path.
        /// </summary>
        [Test]
        public async Task TestGetFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestGetFootnoteWithoutNodePath.docx";

            await this.UploadFileToStorage(
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
            var actual = await this.WordsApi.GetFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" Footnote 1." + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for updating footnote.
        /// </summary>
        [Test]
        public async Task TestUpdateFootnote()
        {
            string remoteFileName = "TestUpdateFootnote.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var requestFootnoteDto = new FootnoteUpdate()
            {
                Text = "new text is here"
            };
            var request = new UpdateFootnoteRequest(
                name: remoteFileName,
                index: 0,
                footnoteDto: requestFootnoteDto,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" new text is here" + "\r\n", actual.Footnote.Text);
        }

        /// <summary>
        /// Test for updating footnote online.
        /// </summary>
        [Test]
        public async Task TestUpdateFootnoteOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + footnoteFolder + "/Footnote.doc");
            var requestFootnoteDto = new FootnoteUpdate()
            {
                Text = "new text is here"
            };
            var request = new UpdateFootnoteOnlineRequest(
                document: requestDocument,
                footnoteDto: requestFootnoteDto,
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.UpdateFootnoteOnline(request);
        }

        /// <summary>
        /// Test for updating footnote without node path.
        /// </summary>
        [Test]
        public async Task TestUpdateFootnoteWithoutNodePath()
        {
            string remoteFileName = "TestUpdateFootnoteWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + footnoteFolder + "/Footnote.doc")
            );

            var requestFootnoteDto = new FootnoteUpdate()
            {
                Text = "new text is here"
            };
            var request = new UpdateFootnoteRequest(
                name: remoteFileName,
                index: 0,
                footnoteDto: requestFootnoteDto,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateFootnote(request);
            Assert.NotNull(actual.Footnote);
            Assert.AreEqual(" new text is here" + "\r\n", actual.Footnote.Text);
        }
    }
}
