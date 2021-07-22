// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentPropertiesTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.DocumentProperties
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to get document properties.
    /// </summary>
    [TestFixture]
    public class DocumentPropertiesTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/DocumentProperties";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for getting document properties.
        /// </summary>
        [Test]
        public void TestGetDocumentProperties()
        {
            string remoteFileName = "TestGetDocumentProperties.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentPropertiesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetDocumentProperties(request);
            Assert.NotNull(actual.DocumentProperties);
            Assert.NotNull(actual.DocumentProperties.List);
            Assert.AreEqual(24, actual.DocumentProperties.List.Count);
            Assert.NotNull(actual.DocumentProperties.List[0]);
            Assert.AreEqual("Author", actual.DocumentProperties.List[0].Name);
            Assert.AreEqual("", actual.DocumentProperties.List[0].Value);
        }

        /// <summary>
        /// Test for getting document properties online.
        /// </summary>
        [Test]
        public void TestGetDocumentPropertiesOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentPropertiesOnlineRequest(
                document: requestDocumentStream
            );
            var actual = this.WordsApi.GetDocumentPropertiesOnline(request);
        }

        /// <summary>
        /// A test for GetDocumentProperty.
        /// </summary>
        [Test]
        public void TestGetDocumentProperty()
        {
            string remoteFileName = "TestGetDocumentProperty.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentPropertyRequest(
                name: remoteFileName,
                propertyName: "Author",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetDocumentProperty(request);
            Assert.NotNull(actual.DocumentProperty);
            Assert.AreEqual("Author", actual.DocumentProperty.Name);
            Assert.AreEqual("", actual.DocumentProperty.Value);
        }

        /// <summary>
        /// A test for GetDocumentProperty online.
        /// </summary>
        [Test]
        public void TestGetDocumentPropertyOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentPropertyOnlineRequest(
                document: requestDocumentStream,
                propertyName: "Author"
            );
            var actual = this.WordsApi.GetDocumentPropertyOnline(request);
        }

        /// <summary>
        /// Test for deleting document property.
        /// </summary>
        [Test]
        public void TestDeleteDocumentProperty()
        {
            string remoteFileName = "TestDeleteDocumentProperty.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteDocumentPropertyRequest(
                name: remoteFileName,
                propertyName: "testProp",
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
        this.WordsApi.DeleteDocumentProperty(request);
        }

        /// <summary>
        /// Test for deleting document property online.
        /// </summary>
        [Test]
        public void TestDeleteDocumentPropertyOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteDocumentPropertyOnlineRequest(
                document: requestDocumentStream,
                propertyName: "testProp"
            );
            var actual = this.WordsApi.DeleteDocumentPropertyOnline(request);
        }

        /// <summary>
        /// Test for updating document property.
        /// </summary>
        [Test]
        public void TestUpdateDocumentProperty()
        {
            string remoteFileName = "TestUpdateDocumentProperty.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new CreateOrUpdateDocumentPropertyRequest(
                name: remoteFileName,
                propertyName: "AsposeAuthor",
                property: new DocumentPropertyCreateOrUpdate()
                {
                    Value = "Imran Anwar"
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = this.WordsApi.CreateOrUpdateDocumentProperty(request);
            Assert.NotNull(actual.DocumentProperty);
            Assert.AreEqual("AsposeAuthor", actual.DocumentProperty.Name);
            Assert.AreEqual("Imran Anwar", actual.DocumentProperty.Value);
        }

        /// <summary>
        /// Test for updating document property online.
        /// </summary>
        [Test]
        public void TestUpdateDocumentPropertyOnline()
        {
            using var requestDocumentStream = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new CreateOrUpdateDocumentPropertyOnlineRequest(
                document: requestDocumentStream,
                propertyName: "AsposeAuthor",
                property: new DocumentPropertyCreateOrUpdate()
                {
                    Value = "Imran Anwar"
                }
            );
            var actual = this.WordsApi.CreateOrUpdateDocumentPropertyOnline(request);
        }
    }
}
