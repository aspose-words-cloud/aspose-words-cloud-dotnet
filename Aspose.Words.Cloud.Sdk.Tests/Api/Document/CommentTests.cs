// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CommentTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Document
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to get comments from document.
    /// </summary>
    [TestFixture]
    public class CommentTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/Comments";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for getting comment by specified comment's index.
        /// </summary>
        [Test]
        public async Task TestGetComment()
        {
            string remoteFileName = "TestGetComment.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetCommentRequest(
                name: remoteFileName,
                commentIndex: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetComment(request);
            Assert.NotNull(actual.Comment);
            Assert.AreEqual("Comment 1" + "\r\n\r\n", actual.Comment.Text);
        }

        /// <summary>
        /// Test for getting comment by specified comment's index online.
        /// </summary>
        [Test]
        public async Task TestGetCommentOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetCommentOnlineRequest(
                document: requestDocument,
                commentIndex: 0
            );
            var actual = await this.WordsApi.GetCommentOnline(request);
        }

        /// <summary>
        /// Test for getting all comments from document.
        /// </summary>
        [Test]
        public async Task TestGetComments()
        {
            string remoteFileName = "TestGetComments.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetCommentsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetComments(request);
            Assert.NotNull(actual.Comments);
            Assert.NotNull(actual.Comments.CommentList);
            Assert.AreEqual(1, actual.Comments.CommentList.Count);
            Assert.AreEqual("Comment 1" + "\r\n\r\n", actual.Comments.CommentList[0].Text);
        }

        /// <summary>
        /// Test for getting all comments from document online.
        /// </summary>
        [Test]
        public async Task TestGetCommentsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetCommentsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetCommentsOnline(request);
        }

        /// <summary>
        /// Test for adding comment.
        /// </summary>
        [Test]
        public async Task TestInsertComment()
        {
            string remoteFileName = "TestInsertComment.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestCommentRangeStartNode = new NodeLink()
            {
                NodeId = "0.3.0.3"
            };
            var requestCommentRangeStart = new DocumentPosition()
            {
                Node = requestCommentRangeStartNode,
                Offset = 0
            };
            var requestCommentRangeEndNode = new NodeLink()
            {
                NodeId = "0.3.0.3"
            };
            var requestCommentRangeEnd = new DocumentPosition()
            {
                Node = requestCommentRangeEndNode,
                Offset = 0
            };
            var requestComment = new CommentInsert()
            {
                RangeStart = requestCommentRangeStart,
                RangeEnd = requestCommentRangeEnd,
                Initial = "IA",
                Author = "Imran Anwar",
                Text = "A new Comment"
            };
            var request = new InsertCommentRequest(
                name: remoteFileName,
                comment: requestComment,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertComment(request);
            Assert.NotNull(actual.Comment);
            Assert.AreEqual("A new Comment" + "\r\n", actual.Comment.Text);
            Assert.NotNull(actual.Comment.RangeStart);
            Assert.NotNull(actual.Comment.RangeStart.Node);
            Assert.AreEqual("0.3.0.4", actual.Comment.RangeStart.Node.NodeId);
        }

        /// <summary>
        /// Test for adding comment online.
        /// </summary>
        [Test]
        public async Task TestInsertCommentOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestCommentRangeStartNode = new NodeLink()
            {
                NodeId = "0.3.0.3"
            };
            var requestCommentRangeStart = new DocumentPosition()
            {
                Node = requestCommentRangeStartNode,
                Offset = 0
            };
            var requestCommentRangeEndNode = new NodeLink()
            {
                NodeId = "0.3.0.3"
            };
            var requestCommentRangeEnd = new DocumentPosition()
            {
                Node = requestCommentRangeEndNode,
                Offset = 0
            };
            var requestComment = new CommentInsert()
            {
                RangeStart = requestCommentRangeStart,
                RangeEnd = requestCommentRangeEnd,
                Initial = "IA",
                Author = "Imran Anwar",
                Text = "A new Comment"
            };
            var request = new InsertCommentOnlineRequest(
                document: requestDocument,
                comment: requestComment
            );
            var actual = await this.WordsApi.InsertCommentOnline(request);
        }

        /// <summary>
        /// Test for updating comment.
        /// </summary>
        [Test]
        public async Task TestUpdateComment()
        {
            string remoteFileName = "TestUpdateComment.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestCommentRangeStartNode = new NodeLink()
            {
                NodeId = "0.3.0"
            };
            var requestCommentRangeStart = new DocumentPosition()
            {
                Node = requestCommentRangeStartNode,
                Offset = 0
            };
            var requestCommentRangeEndNode = new NodeLink()
            {
                NodeId = "0.3.0"
            };
            var requestCommentRangeEnd = new DocumentPosition()
            {
                Node = requestCommentRangeEndNode,
                Offset = 0
            };
            var requestComment = new CommentUpdate()
            {
                RangeStart = requestCommentRangeStart,
                RangeEnd = requestCommentRangeEnd,
                Initial = "IA",
                Author = "Imran Anwar",
                Text = "A new Comment"
            };
            var request = new UpdateCommentRequest(
                name: remoteFileName,
                commentIndex: 0,
                comment: requestComment,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateComment(request);
            Assert.NotNull(actual.Comment);
            Assert.AreEqual("A new Comment" + "\r\n", actual.Comment.Text);
            Assert.NotNull(actual.Comment.RangeStart);
            Assert.NotNull(actual.Comment.RangeStart.Node);
            Assert.AreEqual("0.3.0.1", actual.Comment.RangeStart.Node.NodeId);
        }

        /// <summary>
        /// Test for updating comment online.
        /// </summary>
        [Test]
        public async Task TestUpdateCommentOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestCommentRangeStartNode = new NodeLink()
            {
                NodeId = "0.3.0"
            };
            var requestCommentRangeStart = new DocumentPosition()
            {
                Node = requestCommentRangeStartNode,
                Offset = 0
            };
            var requestCommentRangeEndNode = new NodeLink()
            {
                NodeId = "0.3.0"
            };
            var requestCommentRangeEnd = new DocumentPosition()
            {
                Node = requestCommentRangeEndNode,
                Offset = 0
            };
            var requestComment = new CommentUpdate()
            {
                RangeStart = requestCommentRangeStart,
                RangeEnd = requestCommentRangeEnd,
                Initial = "IA",
                Author = "Imran Anwar",
                Text = "A new Comment"
            };
            var request = new UpdateCommentOnlineRequest(
                document: requestDocument,
                commentIndex: 0,
                comment: requestComment
            );
            var actual = await this.WordsApi.UpdateCommentOnline(request);
        }

        /// <summary>
        /// A test for DeleteComment.
        /// </summary>
        [Test]
        public async Task TestDeleteComment()
        {
            string remoteFileName = "TestDeleteComment.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteCommentRequest(
                name: remoteFileName,
                commentIndex: 0,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
        await this.WordsApi.DeleteComment(request);
        }

        /// <summary>
        /// A test for DeleteComment online.
        /// </summary>
        [Test]
        public async Task TestDeleteCommentOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteCommentOnlineRequest(
                document: requestDocument,
                commentIndex: 0
            );
            var actual = await this.WordsApi.DeleteCommentOnline(request);
        }

        /// <summary>
        /// A test for DeleteComments.
        /// </summary>
        [Test]
        public async Task TestDeleteComments()
        {
            string remoteFileName = "TestDeleteComment.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteCommentsRequest(
                name: remoteFileName,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
        await this.WordsApi.DeleteComments(request);
        }

        /// <summary>
        /// A test for DeleteComments online.
        /// </summary>
        [Test]
        public async Task TestDeleteCommentsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteCommentsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.DeleteCommentsOnline(request);
        }
    }
}
