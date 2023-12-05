// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WatermarkTests.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Watermark
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with watermarks.
    /// </summary>
    [TestFixture]
    public class WatermarkTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/Watermark";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for adding watermark text.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkText()
        {
            string remoteFileName = "TestInsertWatermarkText.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestWatermarkData = new WatermarkDataText()
            {
                Text = "watermark text"
            };
            var request = new InsertWatermarkRequest(
                name: remoteFileName,
                watermarkData: requestWatermarkData,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.InsertWatermark(request);
            Assert.NotNull(actual.Document);
        }

        /// <summary>
        /// Test for adding watermark text online.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkTextOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestWatermarkData = new WatermarkDataText()
            {
                Text = "watermark text"
            };
            var request = new InsertWatermarkOnlineRequest(
                document: requestDocument,
                watermarkData: requestWatermarkData
            );
            var actual = await this.WordsApi.InsertWatermarkOnline(request);
        }

        /// <summary>
        /// Test for adding watermark text.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkImage()
        {
            string remoteFileName = "TestInsertWatermarkImage.docx";
            string remoteImagePath = remoteDataFolder + "/TestInsertWatermarkImage.png";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );
            await this.UploadFileToStorage(
                remoteImagePath,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/aspose-cloud.png")
            );

            var requestWatermarkDataImage = new FileReference(remoteDataFolder + "/" + remoteFileName);
            var requestWatermarkData = new WatermarkDataImage()
            {
                Image = requestWatermarkDataImage
            };
            var request = new InsertWatermarkRequest(
                name: remoteFileName,
                watermarkData: requestWatermarkData,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.InsertWatermark(request);
            Assert.NotNull(actual.Document);
        }

        /// <summary>
        /// Test for adding watermark text online.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkImageOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            using var requestWatermarkDataImageStream = File.OpenRead(LocalTestDataFolder + localFile);
            var requestWatermarkDataImage = new FileReference(requestWatermarkDataImageStream);
            var requestWatermarkData = new WatermarkDataImage()
            {
                Image = requestWatermarkDataImage
            };
            var request = new InsertWatermarkOnlineRequest(
                document: requestDocument,
                watermarkData: requestWatermarkData
            );
            var actual = await this.WordsApi.InsertWatermarkOnline(request);
        }

        /// <summary>
        /// Test for adding watermark image.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkImageDeprecated()
        {
            string remoteFileName = "TestInsertWatermarkImage.docx";
            string remoteImagePath = remoteDataFolder + "/TestInsertWatermarkImage.png";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );
            await this.UploadFileToStorage(
                remoteImagePath,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + "Common/aspose-cloud.png")
            );

            var request = new InsertWatermarkImageRequest(
                name: remoteFileName,
                imageFile: null,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName,
                image: remoteImagePath
            );
            var actual = await this.WordsApi.InsertWatermarkImage(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestInsertWatermarkImage.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for adding watermark image online.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkImageDeprecatedOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            using var requestImageFile = File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png");
            var request = new InsertWatermarkImageOnlineRequest(
                document: requestDocument,
                imageFile: requestImageFile
            );
            var actual = await this.WordsApi.InsertWatermarkImageOnline(request);
        }

        /// <summary>
        /// Test for adding watermark text.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkTextDeprecated()
        {
            string remoteFileName = "TestInsertWatermarkText.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestWatermarkText = new WatermarkText()
            {
                Text = "This is the text",
                RotationAngle = 90.0f
            };
            var request = new InsertWatermarkTextRequest(
                name: remoteFileName,
                watermarkText: requestWatermarkText,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.InsertWatermarkText(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestInsertWatermarkText.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for adding watermark text online.
        /// </summary>
        [Test]
        public async Task TestInsertWatermarkTextDeprecatedOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestWatermarkText = new WatermarkText()
            {
                Text = "This is the text",
                RotationAngle = 90f
            };
            var request = new InsertWatermarkTextOnlineRequest(
                document: requestDocument,
                watermarkText: requestWatermarkText
            );
            var actual = await this.WordsApi.InsertWatermarkTextOnline(request);
        }

        /// <summary>
        /// Test for deleting watermark.
        /// </summary>
        [Test]
        public async Task TestDeleteWatermark()
        {
            string remoteFileName = "TestDeleteWatermark.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteWatermarkRequest(
                name: remoteFileName,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.DeleteWatermark(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestDeleteWatermark.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for deleting watermark online.
        /// </summary>
        [Test]
        public async Task TestDeleteWatermarkOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteWatermarkOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.DeleteWatermarkOnline(request);
        }
    }
}
