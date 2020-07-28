// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertDocumentTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Document
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to convert document to one of the available formats.
    /// </summary>
    [TestFixture]
    public class ConvertDocumentTests : BaseTestContext
    {
        private readonly string remoteFolder = RemoteBaseTestDataFolder + "/DocumentActions/ConvertDocument";
        private readonly string localFolder = "DocumentActions/ConvertDocument";

        /// <summary>
        /// Test for converting document to one of the available formats.
        /// </summary>
        [Test]
        public void TestSaveAs()
        {
            string localName = "test_multi_pages.docx";
            string remoteName = "TestSaveAs.docx";

            this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localName)
            );

            var request = new SaveAsRequest(
                name: remoteName,
                saveOptionsData: new SaveOptionsData()
                {
                    SaveFormat = "pdf",
                    FileName = BaseTestOutPath + "/TestSaveAs.pdf"
                },
                folder: remoteFolder
            );

            var actual = this.WordsApi.SaveAs(request);
        }

        /// <summary>
        /// Test for converting document online to one of the available formats.
        /// </summary>
        [Test]
        public void TestSaveAsOnline()
        {
            string localName = "test_multi_pages.docx";

            var request = new SaveAsOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + "Common/" + localName),
                saveOptionsData: new SaveOptionsData()
                {
                    SaveFormat = "pdf",
                    FileName = BaseTestOutPath + "/TestSaveAs.pdf"
                }
            );

            var actual = this.WordsApi.SaveAsOnline(request);
        }

        /// <summary>
        /// Test for converting document to one of the available formats.
        /// </summary>
        [Test]
        public void TestSaveAsDocx()
        {
            string localName = "45.pdf";
            string remoteName = "TestSaveAsFromPdfToDoc.pdf";

            this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFolder + "/" + localName)
            );

            var request = new SaveAsRequest(
                name: remoteName,
                saveOptionsData: new SaveOptionsData()
                {
                    SaveFormat = "docx",
                    FileName = BaseTestOutPath + "/TestSaveAsFromPdfToDoc.docx"
                },
                folder: remoteFolder
            );

            var actual = this.WordsApi.SaveAs(request);
        }

        /// <summary>
        /// Test for converting document to one of the available formats.
        /// </summary>
        [Test]
        public void TestSaveAsTiff()
        {
            string localName = "test_multi_pages.docx";
            string remoteName = "TestSaveAsTiff.pdf";

            this.UploadFileToStorage(
                remoteFolder + "/" + remoteName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/" + localName)
            );

            var request = new SaveAsTiffRequest(
                name: remoteName,
                saveOptions: new TiffSaveOptionsData()
                {
                    SaveFormat = "tiff",
                    FileName = BaseTestOutPath + "/abc.tiff"
                },
                folder: remoteFolder
            );

            var actual = this.WordsApi.SaveAsTiff(request);
        }

        /// <summary>
        /// A test for ConvertDocument.
        /// </summary>
        [Test]
        public void TestConvertDocument()
        {
            var request = new ConvertDocumentRequest(
                document: File.OpenRead(LocalTestDataFolder + localFolder + "/test_uploadfile.docx"),
                format: "pdf"
            );

            var actual = this.WordsApi.ConvertDocument(request);
        }
    }
}
