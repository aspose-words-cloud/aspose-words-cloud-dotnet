// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FolderTests.cs">
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
    using System.Linq;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with folders    
    /// </summary>
    [TestFixture]
    public class FolderTests : BaseTestContext
    {
        private readonly string storageFolder = RemoteBaseTestDataFolder + "/Storage";

        /// <summary>
        /// Test for create folder
        /// </summary>
        [Test]
        public void TestCreateFolder()
        {
            var request = new CreateFolderRequest($"{this.storageFolder}/TestCreateFolder{Guid.NewGuid()}");
            this.WordsApi.CreateFolder(request);
        }

        /// <summary>
        /// Test for delete folder
        /// </summary>
        [Test]
        public void TestDeleteFolder()
        {
            // Arrange
            var folderPath = $"{this.storageFolder}/TestCreateFolder{Guid.NewGuid()}";            
            this.WordsApi.CreateFolder(new CreateFolderRequest(folderPath));

            var request = new DeleteFolderRequest(folderPath);

            // Act && Assert
            this.WordsApi.DeleteFolder(request);
        }

        /// <summary>
        /// Test for get file list of folder
        /// </summary>
        [Test]
        public void TesGetFileList()
        {           
            // Act && Assert
            var result = this.WordsApi.GetFilesList(new GetFilesListRequest(this.storageFolder));
            Assert.IsTrue(result.Value.Count > 0);
        }

        /// <summary>
        /// Test for copy folder
        /// </summary>
        [Test]
        public void TestCopyFolder()
        {
            // Arrange
            var folderPathSrc = $"{this.storageFolder}/TestCopyFolderSrc{Guid.NewGuid()}";
            var folderPathDest = $"{this.storageFolder}/TestCopyFolderDest{Guid.NewGuid()}";
            this.WordsApi.CreateFolder(new CreateFolderRequest(folderPathSrc));
            
            var request = new CopyFolderRequest(folderPathDest, folderPathSrc);

            // Act
            this.WordsApi.CopyFolder(request);

            // Assert
            var result = this.WordsApi.GetFilesList(new GetFilesListRequest(this.storageFolder));
            Assert.IsTrue(result.Value.Any(p => p.Path == $"/{folderPathDest}/"));
        }

        /// <summary>
        /// Test for move folder
        /// </summary>
        [Test]
        public void TestMoveFolder()
        {
            // Arrange
            var folderPathSrc = $"{this.storageFolder}/TestMoveFolderSrc{Guid.NewGuid()}";
            var folderPathDest = $"{this.storageFolder}/TestMoveFolderDest{Guid.NewGuid()}";
            this.WordsApi.CreateFolder(new CreateFolderRequest(folderPathSrc));

            var request = new MoveFolderRequest(folderPathDest, folderPathSrc);

            // Act
            this.WordsApi.MoveFolder(request);

            // Assert
            var result = this.WordsApi.GetFilesList(new GetFilesListRequest(this.storageFolder));
            Assert.IsTrue(result.Value.Any(p => p.Path == $"/{folderPathDest}/"));
            Assert.IsFalse(result.Value.Any(p => p.Path == $"/{folderPathSrc}/"));
        }
    }
}