// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ListsTests.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
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
        public void TestGetLists()
        {
            string remoteFileName = "TestGetLists.doc";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetListsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetLists(request);
        }

        /// <summary>
        /// Test for getting list from document.
        /// </summary>
        [Test]
        public void TestGetList()
        {
            string remoteFileName = "TestGetList.doc";

            this.UploadFileToStorage(
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

            var actual = this.WordsApi.GetList(request);
        }

        /// <summary>
        /// Test for updating list from document.
        /// </summary>
        [Test]
        public void TestUpdateList()
        {
            string remoteFileName = "TestUpdateList.doc";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateListRequest(
                name: remoteFileName,
                listUpdate: new ListUpdate()
                {
                    IsRestartAtEachSection = true
                },
                listId: 1,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateList(request);
        }

        /// <summary>
        /// Test for updating list level from document.
        /// </summary>
        [Test]
        public void TestUpdateListLevel()
        {
            string remoteFileName = "TestUpdateListLevel.doc";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateListLevelRequest(
                name: remoteFileName,
                listUpdate: new ListLevelUpdate()
                {
                    Alignment = ListLevelUpdate.AlignmentEnum.Right
                },
                listId: 1,
                listLevel: 1,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateListLevel(request);
        }

        /// <summary>
        /// Test for inserting list from document.
        /// </summary>
        [Test]
        public void TestInsertList()
        {
            string remoteFileName = "TestInsertList.doc";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertListRequest(
                name: remoteFileName,
                listInsert: new ListInsert()
                {
                    Template = ListInsert.TemplateEnum.OutlineLegal
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertList(request);
        }
    }
}
