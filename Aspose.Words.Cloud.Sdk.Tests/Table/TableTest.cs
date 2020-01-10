// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="TableTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.Table
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work wtih table
    /// </summary>
    [TestFixture]
    public class TableTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Tables");

        private readonly string tableFolder = "DocumentElements/Tables/";

        /// <summary>
        /// Test for getting tables
        /// </summary>
        [Test]
        public void TestGetTables()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTables.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTablesRequest(remoteName, null, this.dataFolder);
            var actual = this.WordsApi.GetTables(request);
        }

        /// <summary>
        /// Test for getting tables without node path
        /// </summary>
        [Test]
        public void TestGetTablesWithoutNodePath()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTablesWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTablesWithoutNodePathRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetTablesWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting table
        /// </summary>
        [Test]
        public void TestGetTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableRequest(remoteName, null, 1, this.dataFolder);
            var actual = this.WordsApi.GetTable(request);
        }

        /// <summary>
        /// Test for getting table without node path
        /// </summary>
        [Test]
        public void TestGetTableWithoutNodePath()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableWithoutNodePathRequest(remoteName, 1, this.dataFolder);
            var actual = this.WordsApi.GetTableWithoutNodePath(request);
        }

        /// <summary>
        /// Test for deleting table
        /// </summary>
        [Test]
        public void TestDeleteTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteTableRequest(remoteName, null, 1, this.dataFolder);
            this.WordsApi.DeleteTable(request);
        }

        /// <summary>
        /// Test for deleting table without node path
        /// </summary>
        [Test]
        public void TestDeleteTableWithoutNodePath()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTableWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteTableWithoutNodePathRequest(remoteName, 1, this.dataFolder);
            this.WordsApi.DeleteTableWithoutNodePath(request);
        }

        /// <summary>
        /// Test for adding table
        /// </summary>
        [Test]
        public void TestInsertTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestInsertTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var tableDto = new TableInsert { ColumnsCount = 5, RowsCount = 4 };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new InsertTableRequest(remoteName, tableDto, this.dataFolder);
            var actual = this.WordsApi.InsertTable(request);
        }

        /// <summary>
        /// Test for adding table without node path
        /// </summary>
        [Test]
        public void TestInsertTableWithoutNodePath()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestInsertTableWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var tableDto = new TableInsert { ColumnsCount = 5, RowsCount = 4 };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new InsertTableWithoutNodePathRequest(remoteName, tableDto, this.dataFolder);
            var actual = this.WordsApi.InsertTableWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting document properties
        /// </summary>
        [Test]
        public void TestGetTableProperties()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableProperties.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTablePropertiesRequest(remoteName, null, 1, this.dataFolder);
            var actual = this.WordsApi.GetTableProperties(request);
        }

        /// <summary>
        /// Test for getting document properties without node path
        /// </summary>
        [Test]
        public void TestGetTablePropertiesWithoutNodePath()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTablePropertiesWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTablePropertiesWithoutNodePathRequest(remoteName, 1, this.dataFolder);
            var actual = this.WordsApi.GetTablePropertiesWithoutNodePath(request);
        }

        /// <summary>
        /// Test for updating table properties
        /// </summary>
        [Test]
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

            var request = new UpdateTablePropertiesRequest(remoteName, newProperties, null,1, this.dataFolder);
            var actual = this.WordsApi.UpdateTableProperties(request);
        }

        /// <summary>
        /// Test for updating table properties without node path
        /// </summary>
        [Test]
        public void TestUpdateTablePropertiesWithoutNodePath()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestUpdateTablePropertiesWithoutNodePath.docx";
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

            var request = new UpdateTablePropertiesWithoutNodePathRequest(remoteName, newProperties, 1, this.dataFolder);
            var actual = this.WordsApi.UpdateTablePropertiesWithoutNodePath(request);
        }

        /// <summary>
        /// Test for getting table row
        /// </summary>
        [Test]
        public void TestGetTableRow()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableRow.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableRowRequest(remoteName, "tables/1", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableRow(request);
        }

        /// <summary>
        /// Test for deleting table row
        /// </summary>
        [Test]
        public void TestDeleteTableRow()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTableRow.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteTableRowRequest(remoteName, "tables/1", 0, this.dataFolder);
            this.WordsApi.DeleteTableRow(request);
        }

        /// <summary>
        /// Test for adding row
        /// </summary>
        [Test]
        public void TestInsertTableRow()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestInsertTableRow.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var row = new TableRowInsert { ColumnsCount = 5 };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new InsertTableRowRequest(remoteName, row, "sections/0/tables/2", this.dataFolder);
            var actual = this.WordsApi.InsertTableRow(request);
        }

        /// <summary>
        /// Test for getting row format
        /// </summary>
        [Test]
        public void TestGetTableRowFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableRowFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableRowFormatRequest(remoteName, "sections/0/tables/2", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableRowFormat(request);
        }

        /// <summary>
        /// Test updating row format
        /// </summary>
        [Test]
        public void TestUpdateTableRowFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestUpdateTableRowFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var rowFormat = new TableRowFormat { AllowBreakAcrossPages = true, HeadingFormat = true, Height = 10, HeightRule = TableRowFormat.HeightRuleEnum.Auto };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new UpdateTableRowFormatRequest(remoteName, rowFormat, "sections/0/tables/2", 0, this.dataFolder);
            var actual = this.WordsApi.UpdateTableRowFormat(request);
        }

        /// <summary>
        /// Test for getting table cell
        /// </summary>
        [Test]
        public void TestGetTableCell()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableCell.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableCellRequest(remoteName, "sections/0/tables/2/rows/0", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableCell(request);
        }

        /// <summary>
        /// Test for deleting cell
        /// </summary>
        [Test]
        public void TestDeleteCell()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteCell.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteTableCellRequest(remoteName, "sections/0/tables/2/rows/0", 0, this.dataFolder);
            this.WordsApi.DeleteTableCell(request);
        }

        /// <summary>
        /// Test for adding cell
        /// </summary>
        [Test]
        public void TestInsertTableCell()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestInsertTableCell.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var cell = new TableCellInsert();

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new InsertTableCellRequest(remoteName, cell, "sections/0/tables/2/rows/0", this.dataFolder);
            var actual = this.WordsApi.InsertTableCell(request);
        }

        /// <summary>
        /// Test for getting cell format
        /// </summary>
        [Test]
        public void TestGetTableCellFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableCellFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetTableCellFormatRequest(remoteName, "sections/0/tables/2/rows/0", 0, this.dataFolder);
            var actual = this.WordsApi.GetTableCellFormat(request);
        }

        /// <summary>
        /// Test for updating cell format
        /// </summary>
        [Test]
        public void TestUpdateTableCellFormat()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestUpdateTableCellFormat.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var cellFormat = new TableCellFormat { BottomPadding = 5, FitText = true, HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First, WrapText = true };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new UpdateTableCellFormatRequest(remoteName, cellFormat, "sections/0/tables/2/rows/0", 0, this.dataFolder);
            var actual = this.WordsApi.UpdateTableCellFormat(request);
        }

        /// <summary>
        /// Test for table rendering
        /// </summary>
        [Test]
        public void TestRenderTable()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestRenderTable.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var format = "png";
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new RenderTableRequest(remoteName, format, null, index, this.dataFolder);
            var actual = this.WordsApi.RenderTable(request);

            Assert.IsTrue(actual.Length > 0, "Error has occurred while table rendering");
        }

        /// <summary>
        /// Test for table rendering without node path
        /// </summary>
        [Test]
        public void TestRenderTableWithoutNodePath()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestRenderTableWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var format = "png";
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new RenderTableWithoutNodePathRequest(remoteName, format, index, this.dataFolder);
            var actual = this.WordsApi.RenderTableWithoutNodePath(request);

            Assert.IsTrue(actual.Length > 0, "Error has occurred while table rendering");
        }
    }
}