// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ConvertDocumentTest.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Document
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to convert document to one of the available formats
    /// </summary>
    [TestFixture]
    public class ConvertDocumentTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentActions/ConvertDocument");

        private readonly string convertFolder = "DocumentActions/ConvertDocument/";

        /// <summary>
        /// Test for converting document to one of the available formats        
        /// </summary>
        [Test]
        public void TestSaveAs()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestSaveAs.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, Path.GetFileNameWithoutExtension(remoteName) + ".pdf");
            var saveOptionsData = new SaveOptionsData { SaveFormat = "pdf", FileName = destFileName };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new SaveAsRequest(remoteName, saveOptionsData, this.dataFolder);
            var actual = this.WordsApi.SaveAs(request);
        }

        /// <summary>
        /// Test for converting document to one of the available formats        
        /// </summary>
        [Test]
        [Ignore("Until the next release")]
        public void TestSaveAsFromPdfToDoc()
        {
            var localName = "45.pdf";
            var remoteName = "TestSaveAsFromPdfToDoc.pdf";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, Path.GetFileNameWithoutExtension(remoteName) + ".docx");
            var saveOptionsData = new SaveOptionsData { SaveFormat = "docx", FileName = destFileName };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.convertFolder) + localName));

            var request = new SaveAsRequest(remoteName, saveOptionsData, this.dataFolder);
            var actual = this.WordsApi.SaveAs(request);
        }

        /// <summary>
        /// A test for ConvertDocument
        /// </summary>
        [Test]
        public void TestConvertDocument()
        {
            var format = "pdf";
            using (var fileStream = File.OpenRead(BaseTestContext.GetDataDir(this.convertFolder) + "test_uploadfile.docx"))
            {
                var request = new ConvertDocumentRequest(fileStream, format);
                var result = this.WordsApi.ConvertDocument(request);
                Assert.IsTrue(result.Length > 0, "Error occurred while converting document");
            }
        }

        /// <summary>
        /// Test for saving document as a tiff file
        /// </summary>
        [Test]
        public void TestSaveAsTiffonline()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestSaveAsTiffonline.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, Path.GetFileNameWithoutExtension(remoteName) + ".tiff");
            var body = new TiffSaveOptionsData { FileName = "abc.tiff", SaveFormat = "tiff" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new SaveAsTiffRequest(remoteName,
                body,
                this.dataFolder,
                destFileName: destFileName);
            var actual = this.WordsApi.SaveAsTiff(request);
        }
    }
}