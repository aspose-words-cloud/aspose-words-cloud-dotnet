// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CommentTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Document
{
    using System.Collections.Generic;
    using System.IO;
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
        public void TestGetComment()
        {
            string remoteFileName = "TestGetComment.docx";

            this.UploadFileToStorage(
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

            var actual = this.WordsApi.GetComment(request);
            Assert.NotNull(actual.Comment);
            Assert.AreEqual("Comment 1" + "\r\n\r\n", actual.Comment.Text);
        }

        /// <summary>
        /// Test for getting comment by specified comment's index online.
        /// </summary>
        [Test]
        public void TestGetCommentOnline()
        {
            var request = new GetCommentOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                commentIndex: 0
            );

            var actual = this.WordsApi.GetCommentOnline(request);
        }

        /// <summary>
        /// Test for getting all comments from document.
        /// </summary>
        [Test]
        public void TestGetComments()
        {
            string remoteFileName = "TestGetComments.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetCommentsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetComments(request);
            Assert.NotNull(actual.Comments);
            Assert.NotNull(actual.Comments.CommentList);
            Assert.AreEqual(1, actual.Comments.CommentList.Count);
            Assert.AreEqual("Comment 1" + "\r\n\r\n", actual.Comments.CommentList[0].Text);
        }

        /// <summary>
        /// Test for getting all comments from document online.
        /// </summary>
        [Test]
        public void TestGetCommentsOnline()
        {
            var request = new GetCommentsOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile)
            );

            var actual = this.WordsApi.GetCommentsOnline(request);
        }

        /// <summary>
        /// Test for adding comment.
        /// </summary>
        [Test]
        public void TestInsertComment()
        {
            string remoteFileName = "TestInsertComment.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertCommentRequest(
                name: remoteFileName,
                comment: new CommentInsert()
                {
                    RangeStart = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0.3"
                        },
                        Offset = 0
                    },
                    RangeEnd = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0.3"
                        },
                        Offset = 0
                    },
                    Initial = "IA",
                    Author = "Imran Anwar",
                    Text = "A new Comment"
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertComment(request);
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
        public void TestInsertCommentOnline()
        {
            var request = new InsertCommentOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                comment: new CommentInsert()
                {
                    RangeStart = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0.3"
                        },
                        Offset = 0
                    },
                    RangeEnd = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0.3"
                        },
                        Offset = 0
                    },
                    Initial = "IA",
                    Author = "Imran Anwar",
                    Text = "A new Comment"
                }
            );

            var actual = this.WordsApi.InsertCommentOnline(request);
        }

        /// <summary>
        /// Test for updating comment.
        /// </summary>
        [Test]
        public void TestUpdateComment()
        {
            string remoteFileName = "TestUpdateComment.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateCommentRequest(
                name: remoteFileName,
                commentIndex: 0,
                comment: new CommentUpdate()
                {
                    RangeStart = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0"
                        },
                        Offset = 0
                    },
                    RangeEnd = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0"
                        },
                        Offset = 0
                    },
                    Initial = "IA",
                    Author = "Imran Anwar",
                    Text = "A new Comment"
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateComment(request);
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
        public void TestUpdateCommentOnline()
        {
            var request = new UpdateCommentOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                commentIndex: 0,
                comment: new CommentUpdate()
                {
                    RangeStart = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0"
                        },
                        Offset = 0
                    },
                    RangeEnd = new DocumentPosition()
                    {
                        Node = new NodeLink()
                        {
                            NodeId = "0.3.0"
                        },
                        Offset = 0
                    },
                    Initial = "IA",
                    Author = "Imran Anwar",
                    Text = "A new Comment"
                }
            );

            var actual = this.WordsApi.UpdateCommentOnline(request);
        }

        /// <summary>
        /// A test for DeleteComment.
        /// </summary>
        [Test]
        public void TestDeleteComment()
        {
            string remoteFileName = "TestDeleteComment.docx";

            this.UploadFileToStorage(
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

            this.WordsApi.DeleteComment(request);
        }

        /// <summary>
        /// A test for DeleteComment online.
        /// </summary>
        [Test]
        public void TestDeleteCommentOnline()
        {
            var request = new DeleteCommentOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                commentIndex: 0
            );

            var actual = this.WordsApi.DeleteCommentOnline(request);
        }
    }
}
