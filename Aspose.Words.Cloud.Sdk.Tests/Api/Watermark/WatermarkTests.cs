// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WatermarkTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Watermark
{
    using System.Collections.Generic;
    using System.IO;
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
        /// Test for adding watermark image.
        /// </summary>
        [Test]
        public void TestInsertWatermarkImage()
        {
            string remoteFileName = "TestInsertWatermarkImage.docx";
            string remoteImagePath = remoteDataFolder + "/TestInsertWatermarkImage.png";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );
            this.UploadFileToStorage(
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

            var actual = this.WordsApi.InsertWatermarkImage(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestInsertWatermarkImage.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for adding watermark text.
        /// </summary>
        [Test]
        public void TestInsertWatermarkText()
        {
            string remoteFileName = "TestInsertWatermarkText.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertWatermarkTextRequest(
                name: remoteFileName,
                watermarkText: new WatermarkText()
                {
                    Text = "This is the text",
                    RotationAngle = 90f
                },
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );

            var actual = this.WordsApi.InsertWatermarkText(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestInsertWatermarkText.docx", actual.Document.FileName);
        }

        /// <summary>
        /// Test for deleting watermark.
        /// </summary>
        [Test]
        public void TestDeleteWatermark()
        {
            string remoteFileName = "TestDeleteWatermark.docx";

            this.UploadFileToStorage(
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

            var actual = this.WordsApi.DeleteWatermark(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestDeleteWatermark.docx", actual.Document.FileName);
        }
    }
}
