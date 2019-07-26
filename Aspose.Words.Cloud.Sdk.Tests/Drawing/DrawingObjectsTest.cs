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

            var request = new GetDocumentDrawingObjectsRequest(remoteName, "sections/0", this.dataFolder);
            var actual = this.WordsApi.GetDocumentDrawingObjects(request);
        }

        /// <summary>
        /// Test for getting drawing objects from document without node path
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectsWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjectsWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentDrawingObjectsWithoutNodePathRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetDocumentDrawingObjectsWithoutNodePath(request);
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

            var request = new GetDocumentDrawingObjectByIndexRequest(remoteName, "sections/0", objectIndex, this.dataFolder);
            DrawingObjectResponse actual = this.WordsApi.GetDocumentDrawingObjectByIndex(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index without node path
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectByIndexWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjectByIndexWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentDrawingObjectByIndexWithoutNodePathRequest(remoteName, objectIndex, this.dataFolder);
            DrawingObjectResponse actual = this.WordsApi.GetDocumentDrawingObjectByIndexWithoutNodePath(request);
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

            var request = new RenderDrawingObjectRequest(remoteName, format, "sections/0", objectIndex, this.dataFolder);
            var result = this.WordsApi.RenderDrawingObject(request);
            Assert.IsTrue(result.Length > 0, "Error occurred while getting drawing object");
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format without node path
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectByIndexWithFormatWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjectByIndexWithFormatWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;
            var format = "png";

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new RenderDrawingObjectWithoutNodePathRequest(remoteName, format, objectIndex, this.dataFolder);
            var result = this.WordsApi.RenderDrawingObjectWithoutNodePath(request);
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

            var request = new GetDocumentDrawingObjectImageDataRequest(remoteName, "sections/0", objectIndex, this.dataFolder);
            var result = this.WordsApi.GetDocumentDrawingObjectImageData(request);
            Assert.IsTrue(result.Length > 0, "Error occurred while getting drawing object");
        }

        /// <summary>
        /// Test for reading drawing object's image data without node path
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectImageDataWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentDrawingObjectImageDataWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentDrawingObjectImageDataWithoutNodePathRequest(remoteName, objectIndex, this.dataFolder);
            var result = this.WordsApi.GetDocumentDrawingObjectImageDataWithoutNodePath(request);
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

            var request = new GetDocumentDrawingObjectOleDataRequest(remoteName, "sections/0", objectIndex, this.dataFolder );
            var result = this.WordsApi.GetDocumentDrawingObjectOleData(request);
            Assert.IsTrue(result.Length > 0, "Error occurred while getting drawing object");
        }

        /// <summary>
        /// Test for getting drawing object OLE data without node path
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectOleDataWithoutNodePath()
        {
            var localName = "sample_EmbeddedOLE.docx";
            var remoteName = "TestGetDocumentDrawingObjectOleDataWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.drawingFolder) + localName));

            var request = new GetDocumentDrawingObjectOleDataWithoutNodePathRequest(remoteName, objectIndex, this.dataFolder);
            var result = this.WordsApi.GetDocumentDrawingObjectOleDataWithoutNodePath(request);
            Assert.IsTrue(result.Length > 0, "Error occurred while getting drawing object");
        }

        /// <summary>
        /// Test for adding drawing object
        /// </summary>
        [Test]       
        public void TestInsetDrawingObject()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestInsetDrawingObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var image = "aspose-cloud.png";
            using (var file = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + image))
            {               
                var request = new InsertDrawingObjectRequest(remoteName, "{\"Left\": 0}", file, null, this.dataFolder);
                this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

                var actual = this.WordsApi.InsertDrawingObject(request);
            }
        }

        /// <summary>
        /// Test for adding drawing object without node path
        /// </summary>
        [Test]
        public void TestInsetDrawingObjectWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestInsetDrawingObjectWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var image = "aspose-cloud.png";
            using (var file = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + image))
            {
                var request = new InsertDrawingObjectWithoutNodePathRequest(remoteName, "{\"Left\": 0}", file, this.dataFolder);
                this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

                var actual = this.WordsApi.InsertDrawingObjectWithoutNodePath(request);
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

            var request = new DeleteDrawingObjectRequest(remoteName, null, objectIndex, this.dataFolder);
            this.WordsApi.DeleteDrawingObject(request);
        }

        /// <summary>
        /// Test for deleting drawing object without node path
        /// </summary>
        [Test]
        public void TestDeleteDrawingObjectWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestDeleteDrawingObjectWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            int objectIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new DeleteDrawingObjectWithoutNodePathRequest(remoteName, objectIndex, this.dataFolder);
            this.WordsApi.DeleteDrawingObjectWithoutNodePath(request);
        }

        /// <summary>
        /// Test for updating drawing object
        /// </summary>
        [Test]
        public void TestUpdateDrawingObject()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestUpdateDrawingObject.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var image = "aspose-cloud.png";

            using (var file = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + image))
            {
                var request = new UpdateDrawingObjectRequest(remoteName, "{\"Left\": 0}", file, null, 0, this.dataFolder);

                this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

                var actual = this.WordsApi.UpdateDrawingObject(request);
            }
        }

        /// <summary>
        /// Test for updating drawing object without node path
        /// </summary>
        [Test]
        public void TestUpdateDrawingObjectWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestUpdateDrawingObjectWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var image = "aspose-cloud.png";

            using (var file = File.OpenRead(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + image))
            {
                var request = new UpdateDrawingObjectWithoutNodePathRequest(remoteName, "{\"Left\": 0}", file, 0, this.dataFolder);

                this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

                var actual = this.WordsApi.UpdateDrawingObjectWithoutNodePath(request);
            }
        }
    }
}