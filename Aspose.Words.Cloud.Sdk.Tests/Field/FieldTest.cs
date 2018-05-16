// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FieldTest.cs">
// //   Copyright (c) 2018 Aspose.Words for Cloud
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

            var request = new GetFieldsRequest(remoteName, this.dataFolder, nodePath: "sections/0");
            FieldsResponse actual = this.WordsApi.GetFields(request);

            Assert.AreEqual(200, actual.Code);
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

            var request = new GetFieldRequest(remoteName, fieldIndex, this.dataFolder, nodePath: "sections/0/paragraphs/0");
            var actual = this.WordsApi.GetField(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for putting field
        /// </summary>
        [Test]
        public void TestPutField()
        {
            var localName = "SampleWordDocument.docx";
            var remoteName = "TestPutField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            Field body = new Field { Result = "3", FieldCode = "{ NUMPAGES }", NodeId = "0.0.3" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.textFolder) + localName));

            var request = new PutFieldRequest(remoteName, body, this.dataFolder, nodePath: "sections/0/paragraphs/0");
            var actual = this.WordsApi.PutField(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for posting field
        /// </summary>
        [Test]
        public void TestPostField()
        {
            var localName = "GetField.docx";
            var remoteName = "TestPostField.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var fieldIndex = 0;
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new Field { Result = "3", FieldCode = "{ NUMPAGES }", NodeId = "0.0.3" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new PostFieldRequest(remoteName, body, fieldIndex, this.dataFolder, nodePath: "sections/0/paragraphs/0", destFileName: destFileName);
            var actual = this.WordsApi.PostField(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for posting insert page numbers field
        /// </summary>
        [Test]
        public void TestPostInsertPageNumbers()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostInsertPageNumbers.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new PageNumber { Alignment = "center", Format = "{PAGE} of {NUMPAGES}" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PostInsertPageNumbersRequest(remoteName, body, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.PostInsertPageNumbers(request);

            Assert.AreEqual(200, actual.Code);
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

            var request = new DeleteFieldRequest(remoteName, fieldIndex, this.dataFolder, nodePath: "sections/0/paragraphs/0");
            var actual = this.WordsApi.DeleteField(request);

            Assert.AreEqual(200, actual.Code);
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

            var request = new DeleteFieldsRequest(remoteName, this.dataFolder, nodePath: "paragraphs/0");
            var actual = this.WordsApi.DeleteFields(request);

            Assert.AreEqual(200, actual.Code);
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

            var request = new DeleteFieldsRequest(remoteName, this.dataFolder, nodePath: "sections/0");
            var actual = this.WordsApi.DeleteFields(request);

            Assert.AreEqual(200, actual.Code);
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

            var request = new DeleteFieldsRequest(remoteName, this.dataFolder, nodePath: "sections/0/paragraphs/0");
            var actual = this.WordsApi.DeleteFields(request);

            Assert.AreEqual(200, actual.Code);
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

            var request = new DeleteFieldsRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.DeleteFields(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for posting updated fields
        /// </summary>
        [Test]
        public void TestPostUpdateDocumentFields()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostUpdateDocumentFields.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PostUpdateDocumentFieldsRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.PostUpdateDocumentFields(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}