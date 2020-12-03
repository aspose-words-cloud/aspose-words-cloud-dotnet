// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DrawingObjectsTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Drawing
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to get drawing objects.
    /// </summary>
    [TestFixture]
    public class DrawingObjectsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/DrawingObjectss";
        private readonly string localFile = "Common/test_multi_pages.docx";
        private readonly string localDrawingFile = "DocumentElements/DrawingObjects/sample_EmbeddedOLE.docx";

        /// <summary>
        /// Test for getting drawing objects from document.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjects()
        {
            string remoteFileName = "TestGetDocumentDrawingObjects.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjects(request);
        }

        /// <summary>
        /// Test for getting drawing objects from document online.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectsOnline()
        {
            var request = new GetDocumentDrawingObjectsOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                nodePath: "sections/0"
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectsOnline(request);
        }

        /// <summary>
        /// Test for getting drawing objects from document without node path.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectsWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectsWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjects(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectByIndex()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndex.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectByIndexRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectByIndex(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index online.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectByIndexOnline()
        {
            var request = new GetDocumentDrawingObjectByIndexOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                index: 0,
                nodePath: "sections/0"
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectByIndexOnline(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index without node path.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectByIndexWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndexWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectByIndexRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectByIndex(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format.
        /// </summary>
        [Test]
        public void TestRenderDrawingObject()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndexWithFormat.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderDrawingObjectRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.RenderDrawingObject(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format online.
        /// </summary>
        [Test]
        public void TestRenderDrawingObjectOnline()
        {
            var request = new RenderDrawingObjectOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                format: "png",
                index: 0,
                nodePath: "sections/0"
            );

            var actual = this.WordsApi.RenderDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for getting drawing object by specified index and format without node path.
        /// </summary>
        [Test]
        public void TestRenderDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectByIndexWithFormatWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderDrawingObjectRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.RenderDrawingObject(request);
        }

        /// <summary>
        /// Test for reading drawing object's image data.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectImageData()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectImageData.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectImageDataRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectImageData(request);
        }

        /// <summary>
        /// Test for reading drawing object's image data online.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectImageDataOnline()
        {
            var request = new GetDocumentDrawingObjectImageDataOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                index: 0,
                nodePath: "sections/0"
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectImageDataOnline(request);
        }

        /// <summary>
        /// Test for reading drawing object's image data without node path.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectImageDataWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectImageDataWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentDrawingObjectImageDataRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectImageData(request);
        }

        /// <summary>
        /// Test for getting drawing object OLE data.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectOleData()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectOleData.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localDrawingFile)
            );

            var request = new GetDocumentDrawingObjectOleDataRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectOleData(request);
        }

        /// <summary>
        /// Test for getting drawing object OLE data online.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectOleDataOnline()
        {
            var request = new GetDocumentDrawingObjectOleDataOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                index: 0,
                nodePath: "sections/0"
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectOleDataOnline(request);
        }

        /// <summary>
        /// Test for getting drawing object OLE data without node path.
        /// </summary>
        [Test]
        public void TestGetDocumentDrawingObjectOleDataWithoutNodePath()
        {
            string remoteFileName = "TestGetDocumentDrawingObjectOleDataWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localDrawingFile)
            );

            var request = new GetDocumentDrawingObjectOleDataRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.GetDocumentDrawingObjectOleData(request);
        }

        /// <summary>
        /// Test for adding drawing object.
        /// </summary>
        [Test]
        public void TestInsertDrawingObject()
        {
            string remoteFileName = "TestInsetDrawingObject.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: new DrawingObjectInsert()
                {
                    Height = 0f,
                    Left = 0f,
                    Top = 0f,
                    Width = 0f,
                    RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
                    RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
                    WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
                },
                imageFile: File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png"),
                nodePath: "",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertDrawingObject(request);
        }

        /// <summary>
        /// Test for adding drawing object online.
        /// </summary>
        [Test]
        public void TestInsertDrawingObjectOnline()
        {
            var request = new InsertDrawingObjectOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                drawingObject: new DrawingObjectInsert()
                {
                    Height = 0f,
                    Left = 0f,
                    Top = 0f,
                    Width = 0f,
                    RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
                    RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
                    WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
                },
                imageFile: File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png"),
                nodePath: ""
            );

            var actual = this.WordsApi.InsertDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for adding drawing object without node path.
        /// </summary>
        [Test]
        public void TestInsertDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestInsetDrawingObjectWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: new DrawingObjectInsert()
                {
                    Height = 0f,
                    Left = 0f,
                    Top = 0f,
                    Width = 0f,
                    RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
                    RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
                    WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
                },
                imageFile: File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png"),
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.InsertDrawingObject(request);
        }

        /// <summary>
        /// Test for deleting drawing object.
        /// </summary>
        [Test]
        public void TestDeleteDrawingObject()
        {
            string remoteFileName = "TestDeleteDrawingObject.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteDrawingObjectRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteDrawingObject(request);
        }

        /// <summary>
        /// Test for deleting drawing object online.
        /// </summary>
        [Test]
        public void TestDeleteDrawingObjectOnline()
        {
            var request = new DeleteDrawingObjectOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                index: 0,
                nodePath: ""
            );

            var actual = this.WordsApi.DeleteDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for deleting drawing object without node path.
        /// </summary>
        [Test]
        public void TestDeleteDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestDeleteDrawingObjectWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteDrawingObjectRequest(
                name: remoteFileName,
                index: 0,
                folder: remoteDataFolder
            );

            this.WordsApi.DeleteDrawingObject(request);
        }

        /// <summary>
        /// Test for updating drawing object.
        /// </summary>
        [Test]
        public void TestUpdateDrawingObject()
        {
            string remoteFileName = "TestUpdateDrawingObject.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: new DrawingObjectUpdate()
                {
                    Left = 0f
                },
                imageFile: File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png"),
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateDrawingObject(request);
        }

        /// <summary>
        /// Test for updating drawing object online.
        /// </summary>
        [Test]
        public void TestUpdateDrawingObjectOnline()
        {
            var request = new UpdateDrawingObjectOnlineRequest(
                document: File.OpenRead(LocalTestDataFolder + localFile),
                drawingObject: new DrawingObjectUpdate()
                {
                    Left = 0f
                },
                imageFile: File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png"),
                index: 0,
                nodePath: ""
            );

            var actual = this.WordsApi.UpdateDrawingObjectOnline(request);
        }

        /// <summary>
        /// Test for updating drawing object without node path.
        /// </summary>
        [Test]
        public void TestUpdateDrawingObjectWithoutNodePath()
        {
            string remoteFileName = "TestUpdateDrawingObjectWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateDrawingObjectRequest(
                name: remoteFileName,
                drawingObject: new DrawingObjectUpdate()
                {
                    Left = 0f
                },
                imageFile: File.OpenRead(LocalTestDataFolder + "Common/aspose-cloud.png"),
                index: 0,
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.UpdateDrawingObject(request);
        }
    }
}
