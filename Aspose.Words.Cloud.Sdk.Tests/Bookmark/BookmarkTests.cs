// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="BookmarkTests.cs">
// //   Copyright (c) 2019 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Bookmark
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to get all bookmarks from document
    /// </summary>
    [TestFixture]
    public class BookmarkTests : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Bookmarks");

        /// <summary>
        /// Test for getting bookmarks from document
        /// </summary>
        [Test]
        public void TestGetDocumentBookmarks()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentBookmarks.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetBookmarksRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetBookmarks(request);
        }

        /// <summary>
        /// Test for getting bookmark by specified name
        /// </summary>
        [Test]
        public void TestGetDocumentBookmarkByName()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentBookmarkByName.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var bookmarkName = "aspose";

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetBookmarkByNameRequest(remoteName, bookmarkName, this.dataFolder);
            var actual = this.WordsApi.GetBookmarkByName(request);
        }

        /// <summary>
        /// Test for updating existed bookmark
        /// </summary>
        [Test]
        public void TestPostUpdateDocumentBookmark()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentBookmarkByName.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var bookmarkName = "aspose";
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new BookmarkData { Name = bookmarkName, Text = "This will be the text for Aspose" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new UpdateBookmarkRequest(remoteName, body, bookmarkName, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.UpdateBookmark(request);
        }
    }
}