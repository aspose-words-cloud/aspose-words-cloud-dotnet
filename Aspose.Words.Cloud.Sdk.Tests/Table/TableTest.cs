// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="TableTest.cs">
// //   Copyright (c) 2018 Aspose.Words for Cloud
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
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to work wtih table
    /// </summary>
    [TestClass]
    public class TableTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Tables");

        private readonly string tableFolder = "DocumentElements/Tables/";

        /// <summary>
        /// Test for getting tables
        /// </summary>
        [TestMethod]
        public void TestGetTables()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTables.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTablesRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetTables(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting table
        /// </summary>
        [TestMethod]
        public void TestGetTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableRequest(remoteName, 1, this.dataFolder);
            var actual = this.WordsApi.GetTable(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting table
        /// </summary>
        [TestMethod]
        public void TestDeleteTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteTableRequest(remoteName, 1, this.dataFolder);
            var actual = this.WordsApi.DeleteTable(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding table
        /// </summary>
        [TestMethod]
        public void TestInsertTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestInsertTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var tableDto = new TableInsert { ColumnsCount = 5, RowsCount = 4 };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new InsertTableRequest(remoteName, this.dataFolder, table: tableDto);
            var actual = this.WordsApi.InsertTable(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting document properties
        /// </summary>
        [TestMethod]
        public void TestGetTableProperties()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableProperties.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTablePropertiesRequest(remoteName, 1, this.dataFolder);
            var actual = this.WordsApi.GetTableProperties(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for updating table properties
        /// </summary>
        [TestMethod]
        public void TestUpdateTableProperties()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestUpdateTableProperties.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var newProperties = new TableProperties
                                    {
                                        Alignment = TableProperties.AlignmentEnum.Right,
                                        AllowAutoFit = false,
                                        Bidi = true,
                                        BottomPadding = 1,
                                        CellSpacing = 2,
                                        LeftIndent = 3,
                                        LeftPadding = 4,
                                        RightPadding = 5,
                                        StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands,
                                        TopPadding = 6
                                    };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new UpdateTablePropertiesRequest(remoteName, 1, this.dataFolder, properties: newProperties);
            var actual = this.WordsApi.UpdateTableProperties(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting table row
        /// </summary>
        [TestMethod]
        public void TestGetTableRow()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableRow.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableRowRequest(remoteName, "tables/1", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableRow(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting table row
        /// </summary>
        [TestMethod]
        public void TestDeleteTableRow()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTableRow.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteTableRowRequest(remoteName, "tables/1", 0, this.dataFolder);
            var actual = this.WordsApi.DeleteTableRow(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding row
        /// </summary>
        [TestMethod]
        public void TestInsertTableRow()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestInsertTableRow.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var row = new TableRowInsert { ColumnsCount = 5 };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new InsertTableRowRequest(remoteName, "sections/0/tables/2", this.dataFolder, row: row);
            var actual = this.WordsApi.InsertTableRow(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting row format
        /// </summary>
        [TestMethod]
        public void TestGetTableRowFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableRowFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableRowFormatRequest(remoteName, "sections/0/tables/2", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableRowFormat(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test updating row format
        /// </summary>
        [TestMethod]
        public void TestUpdateTableRowFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestUpdateTableRowFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var rowFormat = new TableRowFormat { AllowBreakAcrossPages = true, HeadingFormat = true, Height = 10, HeightRule = TableRowFormat.HeightRuleEnum.Auto };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new UpdateTableRowFormatRequest(remoteName, "sections/0/tables/2", 0, this.dataFolder, format: rowFormat);
            var actual = this.WordsApi.UpdateTableRowFormat(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting table cell
        /// </summary>
        [TestMethod]
        public void TestGetTableCell()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableCell.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableCellRequest(remoteName, "sections/0/tables/2/rows/0", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableCell(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for deleting cell
        /// </summary>
        [TestMethod]
        public void TestDeleteCell()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteCell.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteTableCellRequest(remoteName, "sections/0/tables/2/rows/0", 0, this.dataFolder);
            var actual = this.WordsApi.DeleteTableCell(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding cell
        /// </summary>
        [TestMethod]
        public void TestInsertTableCell()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestInsertTableCell.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var cell = new TableCellInsert();

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new InsertTableCellRequest(remoteName, "sections/0/tables/2/rows/0", this.dataFolder, cell: cell);
            var actual = this.WordsApi.InsertTableCell(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting cell format
        /// </summary>
        [TestMethod]
        public void TestGetTableCellFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableCellFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableCellFormatRequest(remoteName, "sections/0/tables/2/rows/0", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableCellFormat(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for updating cell format
        /// </summary>
        [TestMethod]
        public void TestUpdateTableCellFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestUpdateTableCellFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var cellFormat = new TableCellFormat { BottomPadding = 5, FitText = true, HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First, WrapText = true };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new UpdateTableCellFormatRequest(remoteName, "sections/0/tables/2/rows/0", 0, this.dataFolder, format: cellFormat);
            var actual = this.WordsApi.UpdateTableCellFormat(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for table rendering
        /// </summary>
        [TestMethod]
        public void TestRenderTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestRenderTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var format = "png";
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new RenderTableRequest(remoteName, format, index, this.dataFolder);
            var actual = this.WordsApi.RenderTable(request);

            Assert.IsTrue(actual.Length > 0, "Error has occurred while table rendering");
        }
    }
}