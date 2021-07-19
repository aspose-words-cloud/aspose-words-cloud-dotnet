// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RangeTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Range
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with ranges.
    /// </summary>
    [TestFixture]
    public class RangeTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Range";
        private readonly string localFile = "DocumentElements/Range/RangeGet.doc";

        /// <summary>
        /// Test for getting the text from range.
        /// </summary>
        [Test]
        public void TestGetRangeText()
        {
            string remoteFileName = "TestGetRangeText.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetRangeTextRequest(
                name: remoteFileName,
                rangeStartIdentifier: "id0.0.0",
                rangeEndIdentifier: "id0.0.1",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetRangeText(request);
            Assert.AreEqual("This is HEADER ", actual.Text);
        }

        /// <summary>
        /// Test for getting the text from range online.
        /// </summary>
        [Test]
        public void TestGetRangeTextOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetRangeTextOnlineRequest(
                document: requestDocumentStream,
                rangeStartIdentifier: "id0.0.0",
                rangeEndIdentifier: "id0.0.1"
            );
            var actual = this.WordsApi.GetRangeTextOnline(request);
        }

        /// <summary>
        /// Test for removing the text for range.
        /// </summary>
        [Test]
        public void TestRemoveRange()
        {
            string remoteFileName = "TestRemoveRange.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RemoveRangeRequest(
                name: remoteFileName,
                rangeStartIdentifier: "id0.0.0",
                rangeEndIdentifier: "id0.0.1",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.RemoveRange(request);
        }

        /// <summary>
        /// Test for removing the text for range online.
        /// </summary>
        [Test]
        public void TestRemoveRangeOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new RemoveRangeOnlineRequest(
                document: requestDocumentStream,
                rangeStartIdentifier: "id0.0.0",
                rangeEndIdentifier: "id0.0.1"
            );
            var actual = this.WordsApi.RemoveRangeOnline(request);
        }

        /// <summary>
        /// Test for saving a range as a new document.
        /// </summary>
        [Test]
        public void TestSaveAsRange()
        {
            string remoteFileName = "TestSaveAsRange.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new SaveAsRangeRequest(
                name: remoteFileName,
                rangeStartIdentifier: "id0.0.0",
                documentParameters: new RangeDocument()
                {
                    DocumentName = remoteDataFolder + "/NewDoc.docx"
                },
                rangeEndIdentifier: "id0.0.1",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.SaveAsRange(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("NewDoc.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for saving a range as a new document online.
        /// </summary>
        [Test]
        public void TestSaveAsRangeOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new SaveAsRangeOnlineRequest(
                document: requestDocumentStream,
                rangeStartIdentifier: "id0.0.0",
                documentParameters: new RangeDocument()
                {
                    DocumentName = remoteDataFolder + "/NewDoc.docx"
                },
                rangeEndIdentifier: "id0.0.1"
            );
            var actual = this.WordsApi.SaveAsRangeOnline(request);
        }

        /// <summary>
        /// Test for replacing text in range.
        /// </summary>
        [Test]
        public void TestReplaceWithText()
        {
            string remoteFileName = "TestReplaceWithText.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new ReplaceWithTextRequest(
                name: remoteFileName,
                rangeStartIdentifier: "id0.0.0",
                rangeText: new ReplaceRange()
                {
                    Text = "Replaced header"
                },
                rangeEndIdentifier: "id0.0.1",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.ReplaceWithText(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestReplaceWithText.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for replacing text in range online.
        /// </summary>
        [Test]
        public void TestReplaceWithTextOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new ReplaceWithTextOnlineRequest(
                document: requestDocumentStream,
                rangeStartIdentifier: "id0.0.0",
                rangeText: new ReplaceRange()
                {
                    Text = "Replaced header"
                },
                rangeEndIdentifier: "id0.0.1"
            );
            var actual = this.WordsApi.ReplaceWithTextOnline(request);
        }
    }
}
