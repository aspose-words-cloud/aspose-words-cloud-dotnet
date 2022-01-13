// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListsTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Lists
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with lists.
    /// </summary>
    [TestFixture]
    public class ListsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Lists";
        private readonly string localFile = "DocumentElements/Lists/ListsGet.doc";

        /// <summary>
        /// Test for getting lists from document.
        /// </summary>
        [Test]
        public async Task TestGetLists()
        {
            string remoteFileName = "TestGetLists.doc";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetListsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetLists(request);
            Assert.NotNull(actual.Lists);
            Assert.NotNull(actual.Lists.ListInfo);
            Assert.AreEqual(2, actual.Lists.ListInfo.Count);
            Assert.AreEqual(1, actual.Lists.ListInfo[0].ListId);
        }

        /// <summary>
        /// Test for getting lists from document online.
        /// </summary>
        [Test]
        public async Task TestGetListsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetListsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetListsOnline(request);
        }

        /// <summary>
        /// Test for getting list from document.
        /// </summary>
        [Test]
        public async Task TestGetList()
        {
            string remoteFileName = "TestGetList.doc";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetListRequest(
                name: remoteFileName,
                listId: 1,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetList(request);
            Assert.NotNull(actual.List);
            Assert.AreEqual(1, actual.List.ListId);
        }

        /// <summary>
        /// Test for getting list from document online.
        /// </summary>
        [Test]
        public async Task TestGetListOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetListOnlineRequest(
                document: requestDocument,
                listId: 1
            );
            var actual = await this.WordsApi.GetListOnline(request);
        }

        /// <summary>
        /// Test for updating list from document.
        /// </summary>
        [Test]
        public async Task TestUpdateList()
        {
            string remoteFileName = "TestUpdateList.doc";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestListUpdate = new ListUpdate()
            {
                IsRestartAtEachSection = true
            };
            var request = new UpdateListRequest(
                name: remoteFileName,
                listId: 1,
                listUpdate: requestListUpdate,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateList(request);
        }

        /// <summary>
        /// Test for updating list from document online.
        /// </summary>
        [Test]
        public async Task TestUpdateListOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestListUpdate = new ListUpdate()
            {
                IsRestartAtEachSection = true
            };
            var request = new UpdateListOnlineRequest(
                document: requestDocument,
                listId: 1,
                listUpdate: requestListUpdate
            );
            var actual = await this.WordsApi.UpdateListOnline(request);
            Assert.NotNull(actual.Model.List);
            Assert.AreEqual(1, actual.Model.List.ListId);
            Assert.AreEqual(true, actual.Model.List.IsRestartAtEachSection);
        }

        /// <summary>
        /// Test for updating list level from document.
        /// </summary>
        [Test]
        public async Task TestUpdateListLevel()
        {
            string remoteFileName = "TestUpdateListLevel.doc";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestListUpdate = new ListLevelUpdate()
            {
                Alignment = ListLevelUpdate.AlignmentEnum.Right
            };
            var request = new UpdateListLevelRequest(
                name: remoteFileName,
                listId: 1,
                listLevel: 1,
                listUpdate: requestListUpdate,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateListLevel(request);
        }

        /// <summary>
        /// Test for updating list level from document online.
        /// </summary>
        [Test]
        public async Task TestUpdateListLevelOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestListUpdate = new ListLevelUpdate()
            {
                Alignment = ListLevelUpdate.AlignmentEnum.Right
            };
            var request = new UpdateListLevelOnlineRequest(
                document: requestDocument,
                listId: 1,
                listUpdate: requestListUpdate,
                listLevel: 1
            );
            var actual = await this.WordsApi.UpdateListLevelOnline(request);
            Assert.NotNull(actual.Model.List);
            Assert.NotNull(actual.Model.List.ListLevels);
            Assert.NotNull(actual.Model.List.ListLevels.ListLevel);
            Assert.AreEqual(9, actual.Model.List.ListLevels.ListLevel.Count);

        }

        /// <summary>
        /// Test for inserting list from document.
        /// </summary>
        [Test]
        public async Task TestInsertList()
        {
            string remoteFileName = "TestInsertList.doc";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestListInsert = new ListInsert()
            {
                Template = ListInsert.TemplateEnum.OutlineLegal
            };
            var request = new InsertListRequest(
                name: remoteFileName,
                listInsert: requestListInsert,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertList(request);
            Assert.NotNull(actual.List);
            Assert.AreEqual(3, actual.List.ListId);
        }

        /// <summary>
        /// Test for inserting list from document online.
        /// </summary>
        [Test]
        public async Task TestInsertListOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestListInsert = new ListInsert()
            {
                Template = ListInsert.TemplateEnum.OutlineLegal
            };
            var request = new InsertListOnlineRequest(
                document: requestDocument,
                listInsert: requestListInsert
            );
            var actual = await this.WordsApi.InsertListOnline(request);
        }
    }
}
