// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="DrawingObjectsTest.cs">
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
// //  --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Words.Cloud.Sdk.Tests.Drawing
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to get drawing objects
    /// </summary>
    [TestFixture]
    public class DrawingObjectsTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/DrawingObjects");

        private readonly string drawingFolder = "DocumentElements/DrawingObjects/";

        /// <summary>
        /// Test for getting drawing objects from document
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjects()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjects.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentDrawingObjectsRequest(remoteName, this.dataFolder, nodePath: "sections/0");
            var actual = this.WordsApi.GetDocumentDrawingObjects(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectByIndex()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjectByIndex.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentDrawingObjectByIndexRequest(remoteName, objectIndex, this.dataFolder, nodePath: "sections/0");
            DrawingObjectResponse actual = this.WordsApi.GetDocumentDrawingObjectByIndex(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectByIndexWithFormat()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjectByIndexWithFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;
            var format = "png";

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new RenderDrawingObjectRequest(remoteName, format, objectIndex, this.dataFolder, nodePath: "sections/0");
            var result = this.WordsApi.RenderDrawingObject(request);
            Assert.IsTrue(result.Length > 0, "Error occurred while getting drawing object");
        }

        /// <summary>
        /// Test for reading drawing object's image data
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectImageData()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjectImageData.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentDrawingObjectImageDataRequest(remoteName, objectIndex, this.dataFolder, nodePath: "sections/0");
            var result = this.WordsApi.GetDocumentDrawingObjectImageData(request);
            Assert.IsTrue(result.Length > 0, "Error occurred while getting drawing object");
        }

        /// <summary>
        /// Test for getting drawing object OLE data
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectOleData()
        {
            var localName = "sample_EmbeddedOLE.docx";
            var remoteName = "TestGetDocumentDrawingObjectOleData.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.drawingFolder) + localName));

            var request = new GetDocumentDrawingObjectOleDataRequest(remoteName, objectIndex, this.dataFolder, nodePath: "sections/0");
            var result = this.WordsApi.GetDocumentDrawingObjectOleData(request);
            Assert.IsTrue(result.Length > 0, "Error occurred while getting drawing object");
        }

        /// <summary>
        /// Test for adding drawing object
        /// </summary>
        [Test]       
        public void TestPutDrawingObject()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPutDrawingObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var image = "aspose-cloud.png";
            using (var file = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + image))
            {               
                var request = new PutDrawingObjectRequest(remoteName, "{\"Left\": 0}", file, this.dataFolder);
                this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

                var actual = this.WordsApi.PutDrawingObject(request);
            }
        }

        /// <summary>
        /// Test for deleting drawing object
        /// </summary>
        [Test]
        public void TestDeleteDrawingObject()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteDrawingObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            int objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteDrawingObjectRequest(remoteName, objectIndex, this.dataFolder);
            this.WordsApi.DeleteDrawingObject(request);
        }

        /// <summary>
        /// Test for updating drawing object
        /// </summary>
        [Test]
        public void TestPostDrawingObject()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostDrawingObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var image = "aspose-cloud.png";

            using (var file = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + image))
            {
                var request = new PostDrawingObjectRequest(remoteName, "{\"Left\": 0}", file, 0, this.dataFolder);

                this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

                var actual = this.WordsApi.PostDrawingObject(request);
            }
        }
    }
}