// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FieldTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Field
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with field.
    /// </summary>
    [TestFixture]
    public class FieldTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Fields";
        private readonly string textFolder = "DocumentElements/Text";
        private readonly string fieldFolder = "DocumentElements/Fields";

        /// <summary>
        /// Test for getting fields.
        /// </summary>
        [Test]
        public void TestGetFields()
        {
            string localFileName = "GetField.docx";
            string remoteFileName = "TestGetFields.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/" + localFileName)
            );

            var request = new GetFieldsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetFields(request);
            Assert.NotNull(actual.Fields);
            Assert.NotNull(actual.Fields.List);
            Assert.AreEqual(1, actual.Fields.List.Count);
            Assert.AreEqual("1", actual.Fields.List[0].Result);
        }

        /// <summary>
        /// Test for getting fields online.
        /// </summary>
        [Test]
        public void TestGetFieldsOnline()
        {
            var request = new GetFieldsOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + fieldFolder + "/GetField.docx"),
                nodePath: "sections/0"
            );

            var actual = this.WordsApi.GetFieldsOnline(request);
        }

        /// <summary>
        /// Test for getting fields without node path.
        /// </summary>
        [Test]
        public void TestGetFieldsWithoutNodePath()
        {
            string localFileName = "GetField.docx";
            string remoteFileName = "TestGetFieldsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/" + localFileName)
            );

            var request = new GetFieldsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetFields(request);
            Assert.NotNull(actual.Fields);
            Assert.NotNull(actual.Fields.List);
            Assert.AreEqual(1, actual.Fields.List.Count);
            Assert.AreEqual("1", actual.Fields.List[0].Result);
        }

        /// <summary>
        /// Test for getting field by index.
        /// </summary>
        [Test]
        public void TestGetField()
        {
            string localFileName = "GetField.docx";
            string remoteFileName = "TestGetField.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/" + localFileName)
            );

            var request = new GetFieldRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0/paragraphs/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetField(request);
            Assert.NotNull(actual.Field);
            Assert.AreEqual("1", actual.Field.Result);
        }

        /// <summary>
        /// Test for getting field by index online.
        /// </summary>
        [Test]
        public void TestGetFieldOnline()
        {
            var request = new GetFieldOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + fieldFolder + "/GetField.docx"),
                index: 0,
                nodePath: "sections/0/paragraphs/0"
            );

            var actual = this.WordsApi.GetFieldOnline(request);
        }

        /// <summary>
        /// Test for getting field by index without node path.
        /// </summary>
        [Test]
        public void TestGetFieldWithoutNodePath()
        {
            string localFileName = "GetField.docx";
            string remoteFileName = "TestGetFieldWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/" + localFileName)
            );

            var request = new GetFieldRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetField(request);
            Assert.NotNull(actual.Field);
            Assert.AreEqual("1", actual.Field.Result);
        }

        /// <summary>
        /// Test for putting field.
        /// </summary>
        [Test]
        public void TestInsertField()
        {
            string localFileName = "SampleWordDocument.docx";
            string remoteFileName = "TestInsertField.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + textFolder + "/" + localFileName)
            );

            var request = new InsertFieldRequest(
                name: remoteFileName,
                field: new FieldInsert()
                {
                    FieldCode = "{ NUMPAGES }"
                },
                nodePath: "sections/0/paragraphs/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertField(request);
            Assert.NotNull(actual.Field);
            Assert.AreEqual("{ NUMPAGES }", actual.Field.FieldCode);
            Assert.AreEqual("0.0.0.1", actual.Field.NodeId);
        }

        /// <summary>
        /// Test for putting field online.
        /// </summary>
        [Test]
        public void TestInsertFieldOnline()
        {
            var request = new InsertFieldOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + fieldFolder + "/GetField.docx"),
                field: new FieldInsert()
                {
                    FieldCode = "{ NUMPAGES }"
                },
                nodePath: "sections/0/paragraphs/0"
            );

            var actual = this.WordsApi.InsertFieldOnline(request);
        }

        /// <summary>
        /// Test for putting field without node path.
        /// </summary>
        [Test]
        public void TestInsertFieldWithoutNodePath()
        {
            string localFileName = "SampleWordDocument.docx";
            string remoteFileName = "TestInsertFieldWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + textFolder + "/" + localFileName)
            );

            var request = new InsertFieldRequest(
                name: remoteFileName,
                field: new FieldInsert()
                {
                    FieldCode = "{ NUMPAGES }"
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertField(request);
            Assert.NotNull(actual.Field);
            Assert.AreEqual("{ NUMPAGES }", actual.Field.FieldCode);
            Assert.AreEqual("5.0.22.0", actual.Field.NodeId);
        }

        /// <summary>
        /// Test for posting field.
        /// </summary>
        [Test]
        public void TestUpdateField()
        {
            string localFileName = "GetField.docx";
            string remoteFileName = "TestUpdateField.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/" + localFileName)
            );

            var request = new UpdateFieldRequest(
                name: remoteFileName,
                index: 0,
                field: new FieldUpdate()
                {
                    FieldCode = "{ NUMPAGES }"
                },
                nodePath: "sections/0/paragraphs/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateField(request);
            Assert.NotNull(actual.Field);
            Assert.AreEqual("{ NUMPAGES }", actual.Field.FieldCode);
            Assert.AreEqual("0.0.0.0", actual.Field.NodeId);
        }

        /// <summary>
        /// Test for posting field online.
        /// </summary>
        [Test]
        public void TestUpdateFieldOnline()
        {
            var request = new UpdateFieldOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + fieldFolder + "/GetField.docx"),
                index: 0,
                field: new FieldUpdate()
                {
                    FieldCode = "{ NUMPAGES }"
                },
                nodePath: "sections/0/paragraphs/0"
            );

            var actual = this.WordsApi.UpdateFieldOnline(request);
        }

        /// <summary>
        /// Test for inserting page numbers field.
        /// </summary>
        [Test]
        public void TestInsertPageNumbers()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestInsertPageNumbers.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new InsertPageNumbersRequest(
                name: remoteFileName,
                pageNumber: new PageNumber()
                {
                    Alignment = "center",
                    Format = "{PAGE} of {NUMPAGES}"
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );

            var actual = this.WordsApi.InsertPageNumbers(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestInsertPageNumbers.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for inserting page numbers field online.
        /// </summary>
        [Test]
        public void TestInsertPageNumbersOnline()
        {
            string localFileName = "test_multi_pages.docx";

            var request = new InsertPageNumbersOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + "Common/" + localFileName),
                pageNumber: new PageNumber()
                {
                    Alignment = "center",
                    Format = "{PAGE} of {NUMPAGES}"
                }
            );

            var actual = this.WordsApi.InsertPageNumbersOnline(request);
        }

        /// <summary>
        /// Test for deleting field.
        /// </summary>
        [Test]
        public void TestDeleteField()
        {
            string localFileName = "GetField.docx";
            string remoteFileName = "TestDeleteField.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/" + localFileName)
            );

            var request = new DeleteFieldRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0/paragraphs/0",
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteField(request);
        }

        /// <summary>
        /// Test for deleting field online.
        /// </summary>
        [Test]
        public void TestDeleteFieldOnline()
        {
            var request = new DeleteFieldOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + fieldFolder + "/GetField.docx"),
                index: 0,
                nodePath: "sections/0/paragraphs/0"
            );

            var actual = this.WordsApi.DeleteFieldOnline(request);
        }

        /// <summary>
        /// Test for deleting field without node path.
        /// </summary>
        [Test]
        public void TestDeleteFieldWithoutNodePath()
        {
            string localFileName = "GetField.docx";
            string remoteFileName = "TestDeleteFieldWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + fieldFolder + "/" + localFileName)
            );

            var request = new DeleteFieldRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteField(request);
        }

        /// <summary>
        /// Test for deleting paragraph fields.
        /// </summary>
        [Test]
        public void TestDeleteParagraphFields()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestDeleteParagraphFields.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new DeleteFieldsRequest(
                name: remoteFileName,
                nodePath: "paragraphs/0",
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting paragraph fields without node path.
        /// </summary>
        [Test]
        public void TestDeleteParagraphFieldsWithoutNodePath()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestDeleteParagraphFieldsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new DeleteFieldsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting section fields.
        /// </summary>
        [Test]
        public void TestDeleteSectionFields()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestDeleteSectionFields.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new DeleteFieldsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting section fields without node path.
        /// </summary>
        [Test]
        public void TestDeleteSectionFieldsWithoutNodePath()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestDeleteSectionFieldsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new DeleteFieldsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting paragraph fields in section.
        /// </summary>
        [Test]
        public void TestDeleteSectionParagraphFields()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestDeleteSectionParagraphFields.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new DeleteFieldsRequest(
                name: remoteFileName,
                nodePath: "sections/0/paragraphs/0",
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting fields.
        /// </summary>
        [Test]
        public void TestDeleteDocumentFields()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestDeleteSectionParagraphFields.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new DeleteFieldsRequest(
                name: remoteFileName,
                nodePath: "",
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting fields online.
        /// </summary>
        [Test]
        public void TestDeleteDocumentFieldsOnline()
        {
            string localFileName = "Common/test_multi_pages.docx";

            var request = new DeleteFieldsOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFileName),
                nodePath: ""
            );

            var actual = this.WordsApi.DeleteFieldsOnline(request);
        }

        /// <summary>
        /// Test for posting updated fields.
        /// </summary>
        [Test]
        public void TestUpdateDocumentFields()
        {
            string localFileName = "test_multi_pages.docx";
            string remoteFileName = "TestUpdateDocumentFields.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localFileName)
            );

            var request = new UpdateFieldsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateFields(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestUpdateDocumentFields.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for posting updated fields online.
        /// </summary>
        [Test]
        public void TestUpdateDocumentFieldsOnline()
        {
            string localFile = "Common/test_multi_pages.docx";

            var request = new UpdateFieldsOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile)
            );

            var actual = this.WordsApi.UpdateFieldsOnline(request);
        }
    }
}
