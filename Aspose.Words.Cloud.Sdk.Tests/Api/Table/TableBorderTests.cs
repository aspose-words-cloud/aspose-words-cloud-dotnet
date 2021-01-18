// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableBorderTests.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Table
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with table borders.
    /// </summary>
    [TestFixture]
    public class TableBorderTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Tables";
        private readonly string localFile = "DocumentElements/Tables/TablesGet.docx";

        /// <summary>
        /// Test for getting borders.
        /// </summary>
        [Test]
        public void TestGetBorders()
        {
            string remoteFileName = "TestGetBorders.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetBordersRequest(
                name: remoteFileName,
                nodePath: "tables/1/rows/0/cells/0",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetBorders(request);
            Assert.NotNull(actual.Borders);
            Assert.NotNull(actual.Borders.List);
            Assert.AreEqual(6, actual.Borders.List.Count);
            Assert.NotNull(actual.Borders.List[0].Color);
            Assert.AreEqual("#000000", actual.Borders.List[0].Color.Web);
        }

        /// <summary>
        /// Test for getting borders online.
        /// </summary>
        [Test]
        public void TestGetBordersOnline()
        {
            using var fileStreamDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetBordersOnlineRequest(
                document: fileStreamDocument,
                nodePath: "tables/1/rows/0/cells/0"
            );
            var actual = this.WordsApi.GetBordersOnline(request);
        }

        /// <summary>
        /// Test for getting border.
        /// </summary>
        [Test]
        public void TestGetBorder()
        {
            string remoteFileName = "TestGetBorder.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetBorderRequest(
                name: remoteFileName,
                borderType: "left",
                nodePath: "tables/1/rows/0/cells/0",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.GetBorder(request);
            Assert.NotNull(actual.Border);
            Assert.NotNull(actual.Border.Color);
            Assert.AreEqual("#000000", actual.Border.Color.Web);
        }

        /// <summary>
        /// Test for getting border online.
        /// </summary>
        [Test]
        public void TestGetBorderOnline()
        {
            using var fileStreamDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetBorderOnlineRequest(
                document: fileStreamDocument,
                borderType: "left",
                nodePath: "tables/1/rows/0/cells/0"
            );
            var actual = this.WordsApi.GetBorderOnline(request);
        }

        /// <summary>
        /// Test for deleting borders.
        /// </summary>
        [Test]
        public void TestDeleteBorders()
        {
            string remoteFileName = "TestDeleteBorders.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteBordersRequest(
                name: remoteFileName,
                nodePath: "tables/1/rows/0/cells/0",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.DeleteBorders(request);
        }

        /// <summary>
        /// Test for deleting borders online.
        /// </summary>
        [Test]
        public void TestDeleteBordersOnline()
        {
            using var fileStreamDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteBordersOnlineRequest(
                document: fileStreamDocument,
                nodePath: "tables/1/rows/0/cells/0"
            );
            var actual = this.WordsApi.DeleteBordersOnline(request);
        }

        /// <summary>
        /// Test for deleting border.
        /// </summary>
        [Test]
        public void TestDeleteBorder()
        {
            string remoteFileName = "TestDeleteBorder.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteBorderRequest(
                name: remoteFileName,
                borderType: "left",
                nodePath: "tables/1/rows/0/cells/0",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.DeleteBorder(request);
        }

        /// <summary>
        /// Test for deleting border online.
        /// </summary>
        [Test]
        public void TestDeleteBorderOnline()
        {
            using var fileStreamDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteBorderOnlineRequest(
                document: fileStreamDocument,
                borderType: "left",
                nodePath: "tables/1/rows/0/cells/0"
            );
            var actual = this.WordsApi.DeleteBorderOnline(request);
        }

        /// <summary>
        /// Test for updating border.
        /// </summary>
        [Test]
        public void TestUpdateBorder()
        {
            string remoteFileName = "TestUpdateBorder.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateBorderRequest(
                name: remoteFileName,
                borderType: "left",
                borderProperties: new Border()
                {
                    BorderType = Border.BorderTypeEnum.Left,
                    Color = new XmlColor()
                    {
                        Web = "#AABBCC"
                    },
                    DistanceFromText = 6.0f,
                    LineStyle = Border.LineStyleEnum.DashDotStroker,
                    LineWidth = 2.0f,
                    Shadow = true
                },
                nodePath: "tables/1/rows/0/cells/0",
                folder: remoteDataFolder
            );
            var actual = this.WordsApi.UpdateBorder(request);
            Assert.NotNull(actual.Border);
            Assert.NotNull(actual.Border.Color);
            Assert.AreEqual("#AABBCC", actual.Border.Color.Web);
            Assert.AreEqual(6.0f, actual.Border.DistanceFromText);
            Assert.AreEqual(2.0f, actual.Border.LineWidth);
            Assert.AreEqual(true, actual.Border.Shadow);
        }

        /// <summary>
        /// Test for updating border online.
        /// </summary>
        [Test]
        public void TestUpdateBorderOnline()
        {
            using var fileStreamDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateBorderOnlineRequest(
                document: fileStreamDocument,
                borderProperties: new Border()
                {
                    BorderType = Border.BorderTypeEnum.Left,
                    Color = new XmlColor()
                    {
                        Web = "#AABBCC"
                    },
                    DistanceFromText = 6f,
                    LineStyle = Border.LineStyleEnum.DashDotStroker,
                    LineWidth = 2f,
                    Shadow = true
                },
                borderType: "left",
                nodePath: "tables/1/rows/0/cells/0"
            );
            var actual = this.WordsApi.UpdateBorderOnline(request);
        }
    }
}
