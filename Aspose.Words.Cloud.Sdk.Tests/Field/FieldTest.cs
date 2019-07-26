﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FieldTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.Field
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with field
    /// </summary>
    [TestFixture]
    public class FieldTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Fields");

        private readonly string textFolder = "DocumentElements/Text/";

        private readonly string fieldFolder = "DocumentElements/Fields/";

        /// <summary>
        /// Test for getting fields
        /// </summary>
        [Test]
        public void TestGetFields()
        {
            var localName = "GetField.docx";
            var remoteName = "TestGetFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetFieldsRequest(remoteName, "sections/0", this.dataFolder);
            FieldsResponse actual = this.WordsApi.GetFields(request);
        }

        /// <summary>
        /// Test for getting fields without node path
        /// </summary>
        [Test]
        public void TestGetFieldsWithoutNodePath()
        {
            var localName = "GetField.docx";
            var remoteName = "TestGetFieldsWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetFieldsWithoutNodePathRequest(remoteName, this.dataFolder);
            FieldsResponse actual = this.WordsApi.GetFieldsWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting field by index
        /// </summary>
        [Test]
        public void TestGetField()
        {
            var localName = "GetField.docx";
            var remoteName = "TestGetField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var fieldIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetFieldRequest(remoteName, "sections/0/paragraphs/0", fieldIndex, this.dataFolder);
            var actual = this.WordsApi.GetField(request);
        }

        /// <summary>
        /// Test for getting field by index without node path
        /// </summary>
        [Test]
        public void TestGetFieldWithoutNodePath()
        {
            var localName = "GetField.docx";
            var remoteName = "TestGetFieldWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var fieldIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetFieldWithoutNodePathRequest(remoteName, fieldIndex, this.dataFolder);
            var actual = this.WordsApi.GetFieldWithoutNodePath(request);
        }

        /// <summary>
        /// Test for putting field
        /// </summary>
        [Test]
        public void TestInsertField()
        {
            var localName = "SampleWordDocument.docx";
            var remoteName = "TestInsertField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            Field body = new Field { Result = "3", FieldCode = "{ NUMPAGES }", NodeId = "0.0.3" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.textFolder) + localName));

            var request = new InsertFieldRequest(remoteName, body, "sections/0/paragraphs/0", this.dataFolder);
            var actual = this.WordsApi.InsertField(request);            
        }

        /// <summary> 
        /// Test for putting field without node path
        /// </summary>
        [Test]
        public void TestInsertFieldWithoutNodePath()
        {
            var localName = "SampleWordDocument.docx";
            var remoteName = "TestInsertFieldWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            Field body = new Field { Result = "3", FieldCode = "{ NUMPAGES }", NodeId = "0.0.3" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.textFolder) + localName));

            var request = new InsertFieldWithoutNodePathRequest(remoteName, body, this.dataFolder);
            var actual = this.WordsApi.InsertFieldWithoutNodePath(request);
        }

        /// <summary>
        /// Test for posting field
        /// </summary>
        [Test]
        public void TestUpdateField()
        {
            var localName = "GetField.docx";
            var remoteName = "TestUpdateField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var fieldIndex = 0;
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new Field { Result = "3", FieldCode = "{ NUMPAGES }", NodeId = "0.0.3" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new UpdateFieldRequest(remoteName, body, "sections/0/paragraphs/0", fieldIndex, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.UpdateField(request);
        }

        /// <summary>
        /// Test for inserting page numbers field
        /// </summary>
        [Test]
        public void TestInsertPageNumbers()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestInsertPageNumbers.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new PageNumber { Alignment = "center", Format = "{PAGE} of {NUMPAGES}" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new InsertPageNumbersRequest(remoteName, body, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.InsertPageNumbers(request);
        }

        /// <summary>
        /// Test for deleting field
        /// </summary>
        [Test]
        public void TestDeleteField()
        {
            var localName = "GetField.docx";
            var remoteName = "TestDeleteField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var fieldIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new DeleteFieldRequest(remoteName, "sections/0/paragraphs/0", fieldIndex, this.dataFolder);
            this.WordsApi.DeleteField(request);
        }

        /// <summary>
        /// Test for deleting field without node path
        /// </summary>
        [Test]
        public void TestDeleteFieldWithoutNodePath()
        {
            var localName = "GetField.docx";
            var remoteName = "TestDeleteFieldWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var fieldIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new DeleteFieldWithoutNodePathRequest(remoteName, fieldIndex, this.dataFolder);
            this.WordsApi.DeleteFieldWithoutNodePath(request);
        }

        /// <summary>
        /// Test for deleting paragraph fields
        /// </summary>
        [Test]
        public void TestDeleteParagraphFields()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteParagraphFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteFieldsRequest(remoteName, "paragraphs/0", this.dataFolder);
            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting paragraph fields without node path
        /// </summary>
        [Test]
        public void TestDeleteParagraphFieldsWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteParagraphFieldsWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteFieldsWithoutNodePathRequest(remoteName, this.dataFolder);
            this.WordsApi.DeleteFieldsWithoutNodePath(request);
        }

        /// <summary>
        /// Test for deleting sections fields
        /// </summary>
        [Test]
        public void TestDeleteSectionFields()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteSectionFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteFieldsRequest(remoteName, "sections/0", this.dataFolder);
            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting paragraph fields in section
        /// </summary>
        [Test]
        public void TestDeleteSectionParagraphFields()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteSectionParagraphFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteFieldsRequest(remoteName, "sections/0/paragraphs/0", this.dataFolder);
            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for deleting fields
        /// </summary>
        [Test]
        public void TestDeleteDocumentFields()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteDocumentFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteFieldsRequest(remoteName, null, this.dataFolder);
            this.WordsApi.DeleteFields(request);
        }

        /// <summary>
        /// Test for posting updated fields
        /// </summary>
        [Test]
        public void TestUpdateDocumentFields()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestUpdateDocumentFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new UpdateFieldsRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.UpdateFields(request);
        }
    }
}