// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BookmarkTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Bookmark
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to get all bookmarks from document.
    /// </summary>
    [TestFixture]
    public class BookmarkTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Bookmarks";
        private readonly string localFile = "Common/test_multi_pages.docx";
        private readonly string bookmarkName = "aspose";

        /// <summary>
        /// Test for getting bookmarks from document.
        /// </summary>
        [Test]
        public void TestGetBookmarks()
        {
            string remoteFileName = "TestGetDocumentBookmarks.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetBookmarksRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetBookmarks(request);
        }

        /// <summary>
        /// Test for getting bookmarks from document online.
        /// </summary>
        [Test]
        public void TestGetBookmarksOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetBookmarksOnlineRequest(
                document: documentStream
            );
            var actual = this.WordsApi.GetBookmarksOnline(request);
        }

        /// <summary>
        /// Test for getting bookmark by specified name.
        /// </summary>
        [Test]
        public void TestGetBookmarkByName()
        {
            string remoteFileName = "TestGetDocumentBookmarkByName.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetBookmarkByNameRequest(
                name: remoteFileName,
                bookmarkName: bookmarkName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetBookmarkByName(request);
        }

        /// <summary>
        /// Test for getting bookmark by specified name online.
        /// </summary>
        [Test]
        public void TestGetBookmarkByNameOnline()
        {
            using var documentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetBookmarkByNameOnlineRequest(
                document: documentStream,
                bookmarkName: bookmarkName
            );
            var actual = this.WordsApi.GetBookmarkByNameOnline(request);
        }

        /// <summary>
        /// Test for updating existed bookmark.
        /// </summary>
        [Test]
        public void TestUpdateBookmark()
        {
            string remoteFileName = "TestUpdateDocumentBookmark.docx";
            string bookmarkText = "This will be the text for Aspose";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateBookmarkRequest(
                name: remoteFileName,
                bookmarkName: bookmarkName,
                bookmarkData: new BookmarkData()
                {
                    Name = bookmarkName,
                    Text = bookmarkText
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.UpdateBookmark(request);
        }

        /// <summary>
        /// Test for updating existed bookmark online.
        /// </summary>
        [Test]
        public void TestUpdateBookmarkOnline()
        {
            string remoteFileName = "TestUpdateDocumentBookmark.docx";

            using var documentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateBookmarkOnlineRequest(
                document: documentStream,
                bookmarkName: bookmarkName,
                bookmarkData: new BookmarkData()
                {
                    Name = bookmarkName,
                    Text = "This will be the text for Aspose"
                },
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.UpdateBookmarkOnline(request);
        }
    }
}
