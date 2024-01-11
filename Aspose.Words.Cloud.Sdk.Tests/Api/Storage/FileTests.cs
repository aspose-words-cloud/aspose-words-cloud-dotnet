// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileTests.cs">
//   Copyright (c) 2024 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Storage
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with files.
    /// </summary>
    [TestFixture]
    public class FileTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/Storage";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for uploading file.
        /// </summary>
        [Test]
        public async Task TestUploadFile()
        {
            string remoteFileName = "TestUploadFile.docx";

            using var requestFileContent = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UploadFileRequest(
                fileContent: requestFileContent,
                path: remoteDataFolder + "/" + remoteFileName
            );
            var actual = await this.WordsApi.UploadFile(request);
            Assert.NotNull(actual.Uploaded);
            Assert.AreEqual(1, actual.Uploaded.Count);
            Assert.AreEqual("TestUploadFile.docx", actual.Uploaded[0]);
        }

        /// <summary>
        /// Test for copy file.
        /// </summary>
        [Test]
        public async Task TestCopyFile()
        {
            string remoteFileName = "TestCopyFileSrc.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new CopyFileRequest(
                destPath: remoteDataFolder + "/TestCopyFileDest.docx",
                srcPath: remoteDataFolder + "/" + remoteFileName
            );
        await this.WordsApi.CopyFile(request);
        }

        /// <summary>
        /// Test for move file.
        /// </summary>
        [Test]
        public async Task TestMoveFile()
        {
            string remoteFileName = "TestMoveFileSrc.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new MoveFileRequest(
                destPath: BaseTestOutPath + "/TestMoveFileDest_" + CreateRandomGuid + ".docx",
                srcPath: remoteDataFolder + "/" + remoteFileName
            );
        await this.WordsApi.MoveFile(request);
        }

        /// <summary>
        /// Test for delete file.
        /// </summary>
        [Test]
        public async Task TestDeleteFile()
        {
            string remoteFileName = "TestDeleteFile.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteFileRequest(
                path: remoteDataFolder + "/" + remoteFileName
            );
        await this.WordsApi.DeleteFile(request);
        }

        /// <summary>
        /// Test for download file.
        /// </summary>
        [Test]
        public async Task TestDownloadFile()
        {
            string remoteFileName = "TestDownloadFile.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DownloadFileRequest(
                path: remoteDataFolder + "/" + remoteFileName
            );
            var actual = await this.WordsApi.DownloadFile(request);
        }
    }
}
