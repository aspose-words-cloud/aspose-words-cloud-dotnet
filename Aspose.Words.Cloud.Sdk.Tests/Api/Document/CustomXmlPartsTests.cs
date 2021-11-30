// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CustomXmlPartsTests.cs">
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
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to use custom xml parts in documents.
    /// </summary>
    [TestFixture]
    public class CustomXmlPartsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/CustomXmlParts";
        private readonly string localFile = "DocumentElements/CustomXmlParts/MultipleCustomXmlParts.docx";

        /// <summary>
        /// Test for getting custom xml part by specified index.
        /// </summary>
        [Test]
        public async Task TestGetCustomXmlPart()
        {
            string remoteFileName = "TestGetCustomXmlPart.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetCustomXmlPartRequest(
                name: remoteFileName,
                customXmlPartIndex: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetCustomXmlPart(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("aspose", actual.CustomXmlPart.Id);
            Assert.AreEqual("<Metadata><Author>author1</Author><Initial>initial</Initial><DateTime>2015-01-22T00:00:00</DateTime><Text>text</Text></Metadata>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for getting custom xml part by specified index online.
        /// </summary>
        [Test]
        public async Task TestGetCustomXmlPartOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetCustomXmlPartOnlineRequest(
                document: requestDocument,
                customXmlPartIndex: 0
            );
            var actual = await this.WordsApi.GetCustomXmlPartOnline(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("aspose", actual.CustomXmlPart.Id);
            Assert.AreEqual("<Metadata><Author>author1</Author><Initial>initial</Initial><DateTime>2015-01-22T00:00:00</DateTime><Text>text</Text></Metadata>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for getting all custom xml parts from document.
        /// </summary>
        [Test]
        public async Task TestGetCustomXmlParts()
        {
            string remoteFileName = "TestGetCustomXmlParts.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetCustomXmlPartsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetCustomXmlParts(request);
            Assert.NotNull(actual.CustomXmlParts);
            Assert.NotNull(actual.CustomXmlParts.CustomXmlPartsList);
            Assert.AreEqual(2, actual.CustomXmlParts.CustomXmlPartsList.Count);
            Assert.AreEqual("aspose", actual.CustomXmlParts.CustomXmlPartsList[0].Id);
            Assert.AreEqual("<Metadata><Author>author1</Author><Initial>initial</Initial><DateTime>2015-01-22T00:00:00</DateTime><Text>text</Text></Metadata>", actual.CustomXmlParts.CustomXmlPartsList[0].Data);
        }

        /// <summary>
        /// Test for getting all custom xml parts from document online.
        /// </summary>
        [Test]
        public async Task TestGetCustomXmlPartsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetCustomXmlPartsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetCustomXmlPartsOnline(request);
            Assert.NotNull(actual.CustomXmlParts);
            Assert.NotNull(actual.CustomXmlParts.CustomXmlPartsList);
            Assert.AreEqual(2, actual.CustomXmlParts.CustomXmlPartsList.Count);
            Assert.AreEqual("aspose", actual.CustomXmlParts.CustomXmlPartsList[0].Id);
            Assert.AreEqual("<Metadata><Author>author1</Author><Initial>initial</Initial><DateTime>2015-01-22T00:00:00</DateTime><Text>text</Text></Metadata>", actual.CustomXmlParts.CustomXmlPartsList[0].Data);
        }

        /// <summary>
        /// Test for adding custom xml part.
        /// </summary>
        [Test]
        public async Task TestInsertCustomXmlPart()
        {
            string remoteFileName = "TestInsertCustomXmlPart.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestCustomXmlPart = new CustomXmlPartInsert()
            {
                Id = "hello",
                Data = "<data>Hello world</data>"
            };
            var request = new InsertCustomXmlPartRequest(
                name: remoteFileName,
                customXmlPart: requestCustomXmlPart,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertCustomXmlPart(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("hello", actual.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for adding custom xml part online.
        /// </summary>
        [Test]
        public async Task TestInsertCustomXmlPartOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestCustomXmlPart = new CustomXmlPartInsert()
            {
                Id = "hello",
                Data = "<data>Hello world</data>"
            };
            var request = new InsertCustomXmlPartOnlineRequest(
                document: requestDocument,
                customXmlPart: requestCustomXmlPart
            );
            var actual = await this.WordsApi.InsertCustomXmlPartOnline(request);
            Assert.NotNull(actual.Model.CustomXmlPart);
            Assert.AreEqual("hello", actual.Model.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.Model.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for updating custom xml part.
        /// </summary>
        [Test]
        public async Task TestUpdateCustomXmlPart()
        {
            string remoteFileName = "TestUpdateCustomXmlPart.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestCustomXmlPart = new CustomXmlPartUpdate()
            {
                Data = "<data>Hello world</data>"
            };
            var request = new UpdateCustomXmlPartRequest(
                name: remoteFileName,
                customXmlPartIndex: 0,
                customXmlPart: requestCustomXmlPart,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateCustomXmlPart(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("aspose", actual.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for updating custom xml part online.
        /// </summary>
        [Test]
        public async Task TestUpdateCustomXmlPartOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestCustomXmlPart = new CustomXmlPartUpdate()
            {
                Data = "<data>Hello world</data>"
            };
            var request = new UpdateCustomXmlPartOnlineRequest(
                document: requestDocument,
                customXmlPartIndex: 0,
                customXmlPart: requestCustomXmlPart
            );
            var actual = await this.WordsApi.UpdateCustomXmlPartOnline(request);
            Assert.NotNull(actual.Model.CustomXmlPart);
            Assert.AreEqual("aspose", actual.Model.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.Model.CustomXmlPart.Data);
        }

        /// <summary>
        /// A test for DeleteCustomXmlPart.
        /// </summary>
        [Test]
        public async Task TestDeleteCustomXmlPart()
        {
            string remoteFileName = "TestDeleteCustomXmlPart.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteCustomXmlPartRequest(
                name: remoteFileName,
                customXmlPartIndex: 0,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
        await this.WordsApi.DeleteCustomXmlPart(request);
        }

        /// <summary>
        /// A test for DeleteCustomXmlPart online.
        /// </summary>
        [Test]
        public async Task TestDeleteCustomXmlPartOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteCustomXmlPartOnlineRequest(
                document: requestDocument,
                customXmlPartIndex: 0
            );
            var actual = await this.WordsApi.DeleteCustomXmlPartOnline(request);
        }

        /// <summary>
        /// A test for DeleteCustomXmlParts.
        /// </summary>
        [Test]
        public async Task TestDeleteCustomXmlParts()
        {
            string remoteFileName = "TestDeleteCustomXmlPart.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteCustomXmlPartsRequest(
                name: remoteFileName,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
        await this.WordsApi.DeleteCustomXmlParts(request);
        }

        /// <summary>
        /// A test for DeleteCustomXmlParts online.
        /// </summary>
        [Test]
        public async Task TestDeleteCustomXmlPartsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteCustomXmlPartsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.DeleteCustomXmlPartsOnline(request);
        }
    }
}
