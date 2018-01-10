// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="WatermarkTest.cs">
// //   Copyright (c) 2017 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Tests.Watermark
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to work with watermarks
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class WatermarkTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentActions/Watermark");

        /// <summary>
        /// Test for adding watermark image
        /// </summary>
        [TestMethod]
        public void TestPostInsertDocumentWatermarkImage()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostInsertDocumentWatermarkImage.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            double rotationAngle = 0F;
            var image = "aspose-cloud.png";

            using (var file = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + image))
            {
                this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

                var request = new PostInsertDocumentWatermarkImageRequest(remoteName,
                    file,
                    this.dataFolder,
                    rotationAngle: rotationAngle,
                    destFileName: destFileName);

                var actual = this.WordsApi.PostInsertDocumentWatermarkImage(request);

                Assert.AreEqual(200, actual.Code);
            }
        }

        /// <summary>
        /// Test for adding watermark image from storage
        /// </summary>
        [TestMethod]
        public void TestPostInsertWatermarkImage()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostInsertWatermarkImage.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            double rotationAngle = 0F;
            var localImage = "aspose-cloud.png";
            var remoteImage = "TestPostInsertWatermarkImage.png";
            var fullImagePath = Path.Combine(this.dataFolder, remoteImage);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));
            this.StorageApi.PutCreate(fullImagePath, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localImage));

            var request = new PostInsertDocumentWatermarkImageRequest(remoteName, folder: this.dataFolder, image: fullImagePath, rotationAngle: rotationAngle, destFileName: destFileName);
            var actual = this.WordsApi.PostInsertDocumentWatermarkImage(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding watermark tezt
        /// </summary>
        [TestMethod]
        public void TestPostInsertWatermarkText()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostInsertWatermarkText.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new WatermarkText { Text = "This is the text", RotationAngle = 90.0f };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PostInsertDocumentWatermarkTextRequest(remoteName, body, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.PostInsertDocumentWatermarkText(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting watermark
        /// </summary>
        [TestMethod]
        public void TestDeleteDocumentWatermark()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteDocumentWatermark.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteDocumentWatermarkRequest(remoteName, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.DeleteDocumentWatermark(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}