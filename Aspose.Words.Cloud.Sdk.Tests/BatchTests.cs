// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BatchTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Moq;

    using NUnit.Framework;

    /// <summary>
    /// Tests of batch requests
    /// </summary>
    [TestFixture]
    public class BatchTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Paragraphs";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Check of multiple paragraph operations.
        /// </summary>
        [Test]
        public void TestBatchParagraphs()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndex.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request1 = new GetParagraphsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var request2 = new GetParagraphRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var request3 = new InsertParagraphRequest(
                name: remoteFileName,
                paragraph: new ParagraphInsert()
                {
                    Text = "This is a new paragraph for your document"
                },
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var request4 = new DeleteParagraphRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.Batch(request1, request2, request3, request4);
            Assert.IsTrue(actual.Length == 4);
            Assert.IsTrue(actual[0] is ParagraphLinkCollectionResponse); // GetParagraphs
            Assert.IsTrue(actual[1] is ParagraphResponse); // GetParagraph
            Assert.IsTrue(actual[2] is ParagraphResponse); // InsertParagraph
            Assert.IsTrue(actual[3]  == null); // DeleteParagraph
        }
    }
}
