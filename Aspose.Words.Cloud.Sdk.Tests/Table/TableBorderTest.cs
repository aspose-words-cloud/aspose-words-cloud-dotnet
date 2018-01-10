// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="TableBorderTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.Table
{
    using System.Drawing;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to work with table borders
    /// <remarks>These methods are applicable to cells and rows</remarks>
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class TableBorderTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentElements/TableBorders");

        private readonly string tableFolder = "Table/";

        /// <summary>
        /// Test for getting borders
        /// </summary>
        [TestMethod]
        public void TestGetTableBorders()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableBorders.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetBordersRequest(remoteName, "tables/1/rows/0/cells/0/", this.dataFolder);
            var actual = this.WordsApi.GetBorders(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting border
        /// </summary>
        [TestMethod]
        public void TestGetTableBorder()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableBorder.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetBorderRequest(remoteName, "tables/1/rows/0/cells/0/", 0, this.dataFolder);
            var actual = this.WordsApi.GetBorder(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting borders
        /// </summary>
        [TestMethod]
        public void TestDeleteTableBorders()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTableBorders.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteBordersRequest(remoteName, "tables/1/rows/0/cells/0/", this.dataFolder);
            var actual = this.WordsApi.DeleteBorders(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting border
        /// </summary>
        [TestMethod]
        public void TestDeleteTableBorder()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTableBorder.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteBorderRequest(remoteName, "tables/1/rows/0/cells/0/", 0, this.dataFolder);
            var actual = this.WordsApi.DeleteBorder(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for updating border
        /// </summary>
        [TestMethod]
        public void TestUpdateTableBorder()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestUpdateTableBorder.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var border = new Border
                             {
                                 BorderType = Border.BorderTypeEnum.Left,
                                 Color = new XmlColor { Alpha = 2 },
                                 DistanceFromText = 6,
                                 LineStyle = Border.LineStyleEnum.DashDotStroker,
                                 LineWidth = 2,
                                 Shadow = true
                             };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new UpdateBorderRequest(remoteName, border, "tables/1/rows/0/cells/0/", 0, this.dataFolder);
            var actual = this.WordsApi.UpdateBorder(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}