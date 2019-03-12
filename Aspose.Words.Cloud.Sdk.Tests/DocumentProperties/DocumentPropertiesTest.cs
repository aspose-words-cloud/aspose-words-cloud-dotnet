// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="DocumentPropertiesTest.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.DocumentProperties
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to get document properties
    /// </summary>
    [TestFixture]
    public class DocumentPropertiesTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/DocumentProperties");

        /// <summary>
        /// Test for getting document properties
        /// </summary>
        [Test]
        public void TestGetDocumentProperties()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentProperties.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentPropertiesRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetDocumentProperties(request);            
        }

        /// <summary>
        /// A test for GetDocumentProperty
        /// </summary>
        [Test]
        public void TestGetDocumentProperty()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentProperty.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            string propertyName = "Author";

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentPropertyRequest(remoteName, propertyName, this.dataFolder);
            var actual = this.WordsApi.GetDocumentProperty(request);
        }

        /// <summary>
        /// Test for deleting document property
        /// </summary>
        [Test]
        public void TestDeleteDocumentProperty()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteDocumentProperty.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var propertyName = "testProp";
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var deleteRequest = new DeleteDocumentPropertyRequest(remoteName, propertyName, this.dataFolder, destFileName: destFileName);
            this.WordsApi.DeleteDocumentProperty(deleteRequest);
        }
        
        /// <summary>
        /// Test for updating document property
        /// </summary>
        [Test]
        public void TestPutUpdateDocumentProperty()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPutUpdateDocumentProperty.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var propertyName = "AsposeAuthor";
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            DocumentProperty body = new DocumentProperty { Name = "Author", Value = "Imran Anwar" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new CreateOrUpdateDocumentPropertyRequest(remoteName, propertyName, body, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.CreateOrUpdateDocumentProperty(request);
        }
    }
}