// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HyperlinkTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Hyperlink
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with hyperlinks.
    /// </summary>
    [TestFixture]
    public class HyperlinkTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Hyperlink";
        private readonly string localFile = "Common/test_doc.docx";

        /// <summary>
        /// Test for getting hyperlink by specified index.
        /// </summary>
        [Test]
        public void TestGetDocumentHyperlinkByIndex()
        {
            string remoteFileName = "TestGetDocumentHyperlinkByIndex.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentHyperlinkByIndexRequest(
                name: remoteFileName,
                hyperlinkIndex: 0,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetDocumentHyperlinkByIndex(request);
            Assert.NotNull(actual.Hyperlink);
            Assert.AreEqual("Aspose", actual.Hyperlink.DisplayText);
        }

        /// <summary>
        /// Test for getting hyperlink by specified index online.
        /// </summary>
        [Test]
        public void TestGetDocumentHyperlinkByIndexOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentHyperlinkByIndexOnlineRequest(
                document: requestDocument,
                hyperlinkIndex: 0
            );
            var actual = this.WordsApi.GetDocumentHyperlinkByIndexOnline(request);
        }

        /// <summary>
        /// Test for getting hyperlinks.
        /// </summary>
        [Test]
        public void TestGetDocumentHyperlinks()
        {
            string remoteFileName = "TestGetDocumentHyperlinks.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentHyperlinksRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetDocumentHyperlinks(request);
            Assert.NotNull(actual.Hyperlinks);
            Assert.NotNull(actual.Hyperlinks.HyperlinkList);
            Assert.AreEqual(2, actual.Hyperlinks.HyperlinkList.Count);
            Assert.AreEqual("Aspose", actual.Hyperlinks.HyperlinkList[0].DisplayText);
        }

        /// <summary>
        /// Test for getting hyperlinks online.
        /// </summary>
        [Test]
        public void TestGetDocumentHyperlinksOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentHyperlinksOnlineRequest(
                document: requestDocument
            );
            var actual = this.WordsApi.GetDocumentHyperlinksOnline(request);
        }
    }
}
