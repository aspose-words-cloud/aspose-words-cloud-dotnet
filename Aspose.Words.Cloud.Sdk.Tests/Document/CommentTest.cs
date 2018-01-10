// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="CommentTest.cs">
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
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Tests.Document
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to get comments from document
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class CommentTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentElements/Comments");

        /// <summary>
        /// Test for getting comment by specified comment's index
        /// </summary>
        [TestMethod]
        public void TestGetComment()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetComment.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            int commentIndex = 0;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetCommentRequest(remoteName, commentIndex, this.dataFolder);
            var actual = this.WordsApi.GetComment(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting all comments from document
        /// </summary>
        [TestMethod]
        public void TestGetComments()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetComments.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetCommentsRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetComments(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding comment
        /// </summary>
        [TestMethod]
        public void TestPutComment()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPutComment.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var nodeLink = new NodeLink { NodeId = "0.0.3" };
            var documentPosition = new DocumentPosition { Node = nodeLink, Offset = 0 };
            var body = new Comment
                           {
                               RangeStart = documentPosition,
                               RangeEnd = documentPosition,
                               Initial = "IA",
                               Author = "Imran Anwar",
                               Text = "A new Comment"
                           };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PutCommentRequest(remoteName, body, this.dataFolder);
            var actual = this.WordsApi.PutComment(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding comment
        /// </summary>
        [TestMethod]
        public void TestPostComment()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostComment.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var commentIndex = 0;
            var nodeLink = new NodeLink { NodeId = "0.0.3" };
            var documentPosition = new DocumentPosition { Node = nodeLink, Offset = 0 };
            var body = new Comment
                           {
                               RangeStart = documentPosition,
                               RangeEnd = documentPosition,
                               Initial = "IA",
                               Author = "Imran Anwar",
                               Text = "A new Comment"
                           };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PostCommentRequest(remoteName, commentIndex, body, this.dataFolder);
            var actual = this.WordsApi.PostComment(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteComment
        /// </summary>
        [TestMethod]
        public void TestDeleteComment()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteComment.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var commentIndex = 0;
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteCommentRequest(remoteName, commentIndex, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.DeleteComment(request);
            Assert.AreEqual(200, actual.Code);
        }
    }
}