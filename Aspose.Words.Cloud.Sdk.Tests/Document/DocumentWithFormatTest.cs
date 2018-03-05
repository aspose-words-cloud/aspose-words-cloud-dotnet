// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="DocumentWithFormatTest.cs">
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
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Tests.Document
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Com.Aspose.Storage.Api;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to get document with different format
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class DocumentWithFormatTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentActions/DocumentWithFormat");

        /// <summary>
        /// Test for getting document with specified format
        /// </summary>
        [TestMethod]
        public void TestGetDocumentWithFormat()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentWithFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var format = "text";

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentWithFormatRequest(remoteName, format, this.dataFolder);
            var result = this.WordsApi.GetDocumentWithFormat(request);
            Assert.IsTrue(result.Length > 0, "Conversion has failed");
        }

        /// <summary>
        /// Test for getting document with specified format and outPath
        /// </summary>
        [TestMethod]
        public void TestGetDocumentWithFormatAndOutPath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentWithFormatAndOutPath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var format = "text";
            var destFileName = Path.Combine(BaseTestOutPath, Path.GetFileNameWithoutExtension(remoteName) + ".text");

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentWithFormatRequest(remoteName, format, this.dataFolder, outPath: destFileName);
            this.WordsApi.GetDocumentWithFormat(request);
            var result = this.StorageApi.GetIsExist(destFileName, null, null);
            Assert.IsNotNull(result, "Cannot download document from storage");
            Assert.IsTrue(result.FileExist.IsExist, "File doesn't exist on storage");
        }

        /// <summary>
        /// Test for getting document with specified format and storage
        /// </summary>
        /// TODO Ignore till new storage will be available
        [TestMethod]
        [Ignore]
        public void TestGetDocumentFormatUsingStorage()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentFormatUsingStorage.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var format = "text"; 
            var storage = "AWSStorageS3";

            // TODO to run this test please put your AppKey and AppSid for another storage
            // var anotherStorageApi = new StorageApi(StorageAppKey, StorageAppSID, BaseProductUri);
            // anotherStorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));
            var anotherWordApi = new WordsApi(new Configuration { ApiBaseUrl = BaseProductUri, AppKey = this.AppKey, AppSid = this.AppSid });
            var request = new GetDocumentWithFormatRequest(remoteName, format, this.dataFolder, storage);
            var result = anotherWordApi.GetDocumentWithFormat(request);
            Assert.IsTrue(result.Length > 0, "Conversion has failed");
        }
    }
}