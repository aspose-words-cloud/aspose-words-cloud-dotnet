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
        public void TestGetCustomXmlPart()
        {
            string remoteFileName = "TestGetCustomXmlPart.docx";

            this.UploadFileToStorage(
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
            var actual = this.WordsApi.GetCustomXmlPart(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("aspose", actual.CustomXmlPart.Id);
            Assert.AreEqual("<Metadata><Author>author1</Author><Initial>initial</Initial><DateTime>2015-01-22T00:00:00</DateTime><Text>text</Text></Metadata>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for getting custom xml part by specified index online.
        /// </summary>
        [Test]
        public void TestGetCustomXmlPartOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetCustomXmlPartOnlineRequest(
                document: requestDocumentStream,
                customXmlPartIndex: 0
            );
            var actual = this.WordsApi.GetCustomXmlPartOnline(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("aspose", actual.CustomXmlPart.Id);
            Assert.AreEqual("<Metadata><Author>author1</Author><Initial>initial</Initial><DateTime>2015-01-22T00:00:00</DateTime><Text>text</Text></Metadata>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for getting all custom xml parts from document.
        /// </summary>
        [Test]
        public void TestGetCustomXmlParts()
        {
            string remoteFileName = "TestGetCustomXmlParts.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetCustomXmlPartsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetCustomXmlParts(request);
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
        public void TestGetCustomXmlPartsOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetCustomXmlPartsOnlineRequest(
                document: requestDocumentStream
            );
            var actual = this.WordsApi.GetCustomXmlPartsOnline(request);
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
        public void TestInsertCustomXmlPart()
        {
            string remoteFileName = "TestInsertCustomXmlPart.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertCustomXmlPartRequest(
                name: remoteFileName,
                customXmlPart: new CustomXmlPartInsert()
                {
                    Id = "hello",
                    Data = "<data>Hello world</data>"
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.InsertCustomXmlPart(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("hello", actual.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for adding custom xml part online.
        /// </summary>
        [Test]
        public void TestInsertCustomXmlPartOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertCustomXmlPartOnlineRequest(
                document: requestDocumentStream,
                customXmlPart: new CustomXmlPartInsert()
                {
                    Id = "hello",
                    Data = "<data>Hello world</data>"
                }
            );
            var actual = this.WordsApi.InsertCustomXmlPartOnline(request);
            Assert.NotNull(actual.Model.CustomXmlPart);
            Assert.AreEqual("hello", actual.Model.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.Model.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for updating custom xml part.
        /// </summary>
        [Test]
        public void TestUpdateCustomXmlPart()
        {
            string remoteFileName = "TestUpdateCustomXmlPart.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateCustomXmlPartRequest(
                name: remoteFileName,
                customXmlPartIndex: 0,
                customXmlPart: new CustomXmlPartUpdate()
                {
                    Data = "<data>Hello world</data>"
                },
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateCustomXmlPart(request);
            Assert.NotNull(actual.CustomXmlPart);
            Assert.AreEqual("aspose", actual.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.CustomXmlPart.Data);
        }

        /// <summary>
        /// Test for updating custom xml part online.
        /// </summary>
        [Test]
        public void TestUpdateCustomXmlPartOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateCustomXmlPartOnlineRequest(
                document: requestDocumentStream,
                customXmlPartIndex: 0,
                customXmlPart: new CustomXmlPartUpdate()
                {
                    Data = "<data>Hello world</data>"
                }
            );
            var actual = this.WordsApi.UpdateCustomXmlPartOnline(request);
            Assert.NotNull(actual.Model.CustomXmlPart);
            Assert.AreEqual("aspose", actual.Model.CustomXmlPart.Id);
            Assert.AreEqual("<data>Hello world</data>", actual.Model.CustomXmlPart.Data);
        }

        /// <summary>
        /// A test for DeleteCustomXmlPart.
        /// </summary>
        [Test]
        public void TestDeleteCustomXmlPart()
        {
            string remoteFileName = "TestDeleteCustomXmlPart.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteCustomXmlPart(request);
        }

        /// <summary>
        /// A test for DeleteCustomXmlPart online.
        /// </summary>
        [Test]
        public void TestDeleteCustomXmlPartOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteCustomXmlPartOnlineRequest(
                document: requestDocumentStream,
                customXmlPartIndex: 0
            );
            var actual = this.WordsApi.DeleteCustomXmlPartOnline(request);
        }

        /// <summary>
        /// A test for DeleteCustomXmlParts.
        /// </summary>
        [Test]
        public void TestDeleteCustomXmlParts()
        {
            string remoteFileName = "TestDeleteCustomXmlPart.docx";

            this.UploadFileToStorage(
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
        this.WordsApi.DeleteCustomXmlParts(request);
        }

        /// <summary>
        /// A test for DeleteCustomXmlParts online.
        /// </summary>
        [Test]
        public void TestDeleteCustomXmlPartsOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteCustomXmlPartsOnlineRequest(
                document: requestDocumentStream
            );
            var actual = this.WordsApi.DeleteCustomXmlPartsOnline(request);
        }
    }
}
