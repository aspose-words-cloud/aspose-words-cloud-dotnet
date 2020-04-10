// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ListsTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Lists
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Range related tests
    /// </summary>
    [TestFixture]
    public class ListsTests : BaseTestContext
    {
        private readonly string localDataFolder = "DocumentElements/Lists/";
        private readonly string remoteDataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Lists/");
        private readonly string localName = "ListsGet.doc";

        /// <summary>
        /// Test for getting lists from document.
        /// </summary>
        [Test]
        public void GetLists()
        {
            var remoteName = "TestGetLists.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var request = new GetListsRequest(remoteName, folder: this.remoteDataFolder);
            var respose = this.WordsApi.GetLists(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for getting list from document.
        /// </summary>
        [Test]
        public void GetList()
        {
            var remoteName = "TestGetList.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var request = new GetListRequest(remoteName, 1, folder: this.remoteDataFolder);
            var respose = this.WordsApi.GetList(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for updating list from document.
        /// </summary>
        [Test]
        public void UpdateList()
        {
            var remoteName = "TestUpdateList.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var data = new ListUpdate();
            data.IsRestartAtEachSection = true;

            var request = new UpdateListRequest(remoteName, data, 1, folder: this.remoteDataFolder);
            var respose = this.WordsApi.UpdateList(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for updating list level from document.
        /// </summary>
        [Test]
        public void UpdateListLevel()
        {
            var remoteName = "TestUpdateListLevel.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var data = new ListLevelUpdate();
            data.Alignment = ListLevelUpdate.AlignmentEnum.Right;

            var request = new UpdateListLevelRequest(remoteName, data, 1, 1, folder: this.remoteDataFolder);
            var respose = this.WordsApi.UpdateListLevel(request);
            Assert.NotNull(respose);
        }

        /// <summary>
        /// Test for inserting list from document.
        /// </summary>
        [Test]
        public void InsertList()
        {
            var remoteName = "TestInsertList.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var data = new ListInsert();
            data.Template = ListInsert.TemplateEnum.OutlineLegal;

            var request = new InsertListRequest(remoteName, data, folder: this.remoteDataFolder);
            var respose = this.WordsApi.InsertList(request);
            Assert.NotNull(respose);
        }
    }
}
