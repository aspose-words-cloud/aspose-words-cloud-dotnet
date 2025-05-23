// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompareDocumentTests.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    /// Example of document comparison.
    /// </summary>
    [TestFixture]
    public class CompareDocumentTests : BaseTestContext
    {
        private readonly string remoteFolder = RemoteBaseTestDataFolder + "/DocumentActions/CompareDocument";
        private readonly string localFolder = "DocumentActions/CompareDocument";

        /// <summary>
        /// Test for document comparison.
        /// </summary>
        [Test]
        public async Task TestCompareDocument()
        {
            string localName1 = "compareTestDoc1.doc";
            string localName2 = "compareTestDoc2.doc";
            string remoteName1 = "TestCompareDocument1.doc";
            string remoteName2 = "TestCompareDocument2.doc";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName1,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + localName1)
            );
            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName2,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + localName2)
            );

            var requestCompareDataFileReference = new FileReference(remoteFolder + "/" + remoteName2);
            var requestCompareData = new CompareData()
            {
                Author = "author",
                DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0),
                FileReference = requestCompareDataFileReference
            };
            var request = new CompareDocumentRequest(
                name: remoteName1,
                compareData: requestCompareData,
                folder: remoteFolder,
                destFileName: BaseTestOutPath + "/TestCompareDocumentOut.doc"
            );
            var actual = await this.WordsApi.CompareDocument(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestCompareDocumentOut.doc", actual.Document.FileName);
        }

        /// <summary>
        /// Test for document comparison online.
        /// </summary>
        [Test]
        public async Task TestCompareDocumentOnline()
        {
            string localName1 = "compareTestDoc1.doc";
            string localName2 = "compareTestDoc2.doc";
            string remoteName2 = "TestCompareDocument2.doc";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName2,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + localName2)
            );

            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/" + localName1);
            var requestCompareDataFileReference = new FileReference(remoteFolder + "/" + remoteName2);
            var requestCompareData = new CompareData()
            {
                Author = "author",
                DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0),
                FileReference = requestCompareDataFileReference
            };
            var request = new CompareDocumentOnlineRequest(
                document: requestDocument,
                compareData: requestCompareData,
                destFileName: BaseTestOutPath + "/TestCompareDocumentOut.doc"
            );
            var actual = await this.WordsApi.CompareDocumentOnline(request);
        }

        /// <summary>
        /// Test for document comparison online.
        /// </summary>
        [Test]
        public async Task TestCompareTwoDocumentOnline()
        {
            string localName1 = "compareTestDoc1.doc";
            string localName2 = "compareTestDoc2.doc";
            string remoteName2 = "TestCompareDocument2.doc";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName2,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + localName2)
            );

            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFolder + "/" + localName1);
            using var requestCompareDataFileReferenceStream = File.OpenRead(LocalTestDataFolder + localFolder + "/" + localName2);
            var requestCompareDataFileReference = new FileReference(requestCompareDataFileReferenceStream);
            var requestCompareData = new CompareData()
            {
                Author = "author",
                DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0),
                FileReference = requestCompareDataFileReference
            };
            var request = new CompareDocumentOnlineRequest(
                document: requestDocument,
                compareData: requestCompareData,
                destFileName: BaseTestOutPath + "/TestCompareDocumentOut.doc"
            );
            var actual = await this.WordsApi.CompareDocumentOnline(request);
        }

        /// <summary>
        /// Test for document comparison with password protection.
        /// </summary>
        [Test]
        public async Task TestCompareDocumentWithPassword()
        {
            string localName = "DocWithPassword.docx";
            string remoteName1 = "TestCompareDocument1.docx";
            string remoteName2 = "TestCompareDocument2.docx";

            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName1,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localName)
            );
            await this.UploadFileToStorage(
                remoteFolder + "/" + remoteName2,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localName)
            );

            var requestCompareDataFileReference = new FileReference(remoteFolder + "/" + remoteName2, "12345");
            var requestCompareData = new CompareData()
            {
                Author = "author",
                DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0),
                FileReference = requestCompareDataFileReference
            };
            var request = new CompareDocumentRequest(
                name: remoteName1,
                compareData: requestCompareData,
                folder: remoteFolder,
                password: "12345",
                destFileName: BaseTestOutPath + "/TestCompareDocumentOut.docx"
            );
            var actual = await this.WordsApi.CompareDocument(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestCompareDocumentOut.docx", actual.Document.FileName);
        }
    }
}
