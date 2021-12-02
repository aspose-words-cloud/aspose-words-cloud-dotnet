// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FolderTests.cs">
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
    /// Example of how to work with folders.
    /// </summary>
    [TestFixture]
    public class FolderTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/Storage";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for create folder.
        /// </summary>
        [Test]
        public async Task TestCreateFolder()
        {
            var request = new CreateFolderRequest(
                path: remoteDataFolder + "/TestCreateFolder"
            );
        await this.WordsApi.CreateFolder(request);
        }

        /// <summary>
        /// Test for delete folder.
        /// </summary>
        [Test]
        public async Task TestDeleteFolder()
        {
            string testDeleteFolder = remoteDataFolder + "/TestDeleteFolder";

            await this.UploadFileToStorage(
                testDeleteFolder + "/TestDeleteFolder.docx",
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteFolderRequest(
                path: testDeleteFolder
            );
        await this.WordsApi.DeleteFolder(request);
        }

        /// <summary>
        /// Test for get file list of folder.
        /// </summary>
        [Test]
        public async Task TestGetFilesList()
        {
            var request = new GetFilesListRequest(
                path: remoteDataFolder
            );
            var actual = await this.WordsApi.GetFilesList(request);
            Assert.NotNull(actual.Value);
        }

        /// <summary>
        /// Test for copy folder.
        /// </summary>
        [Test]
        public async Task TestCopyFolder()
        {
            string folderToCopy = remoteDataFolder + "/TestCopyFolder";

            await this.UploadFileToStorage(
                folderToCopy + "Src/TestCopyFolderSrc.docx",
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new CopyFolderRequest(
                destPath: folderToCopy + "Dest",
                srcPath: folderToCopy + "Src"
            );
        await this.WordsApi.CopyFolder(request);
        }

        /// <summary>
        /// Test for move folder.
        /// </summary>
        [Test]
        public async Task TestMoveFolder()
        {
            await this.UploadFileToStorage(
                remoteDataFolder + "/TestMoveFolderSrc/TestMoveFolderSrc.docx",
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new MoveFolderRequest(
                destPath: BaseTestOutPath + "/TestMoveFolderDest_" + CreateRandomGuid,
                srcPath: remoteDataFolder + "/TestMoveFolderSrc"
            );
        await this.WordsApi.MoveFolder(request);
        }
    }
}
