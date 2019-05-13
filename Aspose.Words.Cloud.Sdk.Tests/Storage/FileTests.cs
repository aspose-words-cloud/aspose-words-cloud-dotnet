// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FileTests.cs">
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
// //  --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Words.Cloud.Sdk.Tests.Storage
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
        /// Example of how to work with files    
        /// </summary>
        [TestFixture]
    public class FileTests : BaseTestContext
    {
        /// <summary>
        /// Test for uploading file
        /// </summary>
        [Test]
        public void TestUploadFile()
        {
            var localName = "test_multi_pages.docx";
            var remotePath = Path.Combine(RemoteBaseTestDataFolder, "TestUploadFile.docx");
            using (var ms = new MemoryStream(
                File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName)))
            {
                var request = new UploadFileRequest(ms, remotePath);
                this.WordsApi.UploadFile(request);
            }
        }

        /// <summary>
        /// Test for copy file
        /// </summary>
        [Test]
        public void TestCopyFile()
        {
            // Arrange
            var localName = "test_multi_pages.docx";
            var remoteBasePathSrc = Path.Combine(RemoteBaseTestDataFolder, "TestCopyFileSrc.docx");
            var remoteBasePathDest = Path.Combine(RemoteBaseTestDataFolder, $"TestCopyFileDest{Guid.NewGuid()}.docx");

            this.UploadFileToStorage(remoteBasePathSrc, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new CopyFileRequest(remoteBasePathSrc, remoteBasePathDest);

            // Act
            this.WordsApi.CopyFile(request);

            // Assert
            using (var result = this.WordsApi.DownloadFile(new DownloadFileRequest(remoteBasePathDest)))
            {
                Assert.IsTrue(result.Length > 0);
            }
        }

        /// <summary>
        /// Test for move file
        /// </summary>
        [Test]
        public void TestMoveFile()
        {
            // Arrange
            var localName = "test_multi_pages.docx";
            var remoteBasePathSrc = Path.Combine(RemoteBaseTestDataFolder, "TestMoveFileSrc.docx");
            var remoteBasePathDest = Path.Combine(RemoteBaseTestDataFolder, $"TestMoveFileDest{Guid.NewGuid()}.docx");

            this.UploadFileToStorage(remoteBasePathSrc, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new MoveFileRequest(remoteBasePathSrc, remoteBasePathDest);

            // Act
            this.WordsApi.MoveFile(request);

            // Assert
            using (var result = this.WordsApi.DownloadFile(new DownloadFileRequest(remoteBasePathDest)))
            {
                Assert.IsTrue(result.Length > 0);
            }
            
            var exc = Assert.Throws<ApiException>(() => this.WordsApi.DownloadFile(new DownloadFileRequest(remoteBasePathSrc)));
            Assert.AreEqual(404, exc.ErrorCode);
        }
    }
}