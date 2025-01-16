// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableTests.cs">
//   Copyright (c) 2025 Aspose.Words for Cloud
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
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work wtih table.
    /// </summary>
    [TestFixture]
    public class TableTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Tables";
        private readonly string localFile = "DocumentElements/Tables/TablesGet.docx";

        /// <summary>
        /// Test for getting tables.
        /// </summary>
        [Test]
        public async Task TestGetTables()
        {
            string remoteFileName = "TestGetTables.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTablesRequest(
                name: remoteFileName,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTables(request);
            Assert.NotNull(actual.Tables);
            Assert.NotNull(actual.Tables.TableLinkList);
            Assert.AreEqual(5, actual.Tables.TableLinkList.Count);
            Assert.AreEqual("0.0.1", actual.Tables.TableLinkList[0].NodeId);
        }

        /// <summary>
        /// Test for getting tables online.
        /// </summary>
        [Test]
        public async Task TestGetTablesOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTablesOnlineRequest(
                document: requestDocument,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetTablesOnline(request);
        }

        /// <summary>
        /// Test for getting tables without node path.
        /// </summary>
        [Test]
        public async Task TestGetTablesWithoutNodePath()
        {
            string remoteFileName = "TestGetTablesWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTablesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTables(request);
            Assert.NotNull(actual.Tables);
            Assert.NotNull(actual.Tables.TableLinkList);
            Assert.AreEqual(5, actual.Tables.TableLinkList.Count);
            Assert.AreEqual("0.0.1", actual.Tables.TableLinkList[0].NodeId);
        }

        /// <summary>
        /// Test for getting table.
        /// </summary>
        [Test]
        public async Task TestGetTable()
        {
            string remoteFileName = "TestGetTable.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTableRequest(
                name: remoteFileName,
                index: 1,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTable(request);
            Assert.NotNull(actual.Table);
            Assert.NotNull(actual.Table.TableRowList);
            Assert.AreEqual(1, actual.Table.TableRowList.Count);
            Assert.NotNull(actual.Table.TableRowList[0].TableCellList);
            Assert.AreEqual(2, actual.Table.TableRowList[0].TableCellList.Count);
        }

        /// <summary>
        /// Test for getting table online.
        /// </summary>
        [Test]
        public async Task TestGetTableOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableOnlineRequest(
                document: requestDocument,
                index: 1,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetTableOnline(request);
        }

        /// <summary>
        /// Test for getting table without node path.
        /// </summary>
        [Test]
        public async Task TestGetTableWithoutNodePath()
        {
            string remoteFileName = "TestGetTableWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTableRequest(
                name: remoteFileName,
                index: 1,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTable(request);
            Assert.NotNull(actual.Table);
            Assert.NotNull(actual.Table.TableRowList);
            Assert.AreEqual(1, actual.Table.TableRowList.Count);
            Assert.NotNull(actual.Table.TableRowList[0].TableCellList);
            Assert.AreEqual(2, actual.Table.TableRowList[0].TableCellList.Count);
        }

        /// <summary>
        /// Test for deleting table.
        /// </summary>
        [Test]
        public async Task TestDeleteTable()
        {
            string remoteFileName = "TestDeleteTable.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteTableRequest(
                name: remoteFileName,
                index: 1,
                nodePath: "",
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteTable(request);
        }

        /// <summary>
        /// Test for deleting table online.
        /// </summary>
        [Test]
        public async Task TestDeleteTableOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteTableOnlineRequest(
                document: requestDocument,
                index: 1,
                nodePath: ""
            );
            var actual = await this.WordsApi.DeleteTableOnline(request);
        }

        /// <summary>
        /// Test for deleting table without node path.
        /// </summary>
        [Test]
        public async Task TestDeleteTableWithoutNodePath()
        {
            string remoteFileName = "TestDeleteTableWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteTableRequest(
                name: remoteFileName,
                index: 1,
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteTable(request);
        }

        /// <summary>
        /// Test for adding table.
        /// </summary>
        [Test]
        public async Task TestInsertTable()
        {
            string remoteFileName = "TestInsertTable.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestTable = new TableInsert()
            {
                ColumnsCount = 5,
                RowsCount = 4
            };
            var request = new InsertTableRequest(
                name: remoteFileName,
                table: requestTable,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertTable(request);
            Assert.NotNull(actual.Table);
            Assert.NotNull(actual.Table.TableRowList);
            Assert.AreEqual(4, actual.Table.TableRowList.Count);
            Assert.NotNull(actual.Table.TableRowList[0].TableCellList);
            Assert.AreEqual(5, actual.Table.TableRowList[0].TableCellList.Count);
        }

        /// <summary>
        /// Test for adding table online.
        /// </summary>
        [Test]
        public async Task TestInsertTableOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestTable = new TableInsert()
            {
                ColumnsCount = 5,
                RowsCount = 4
            };
            var request = new InsertTableOnlineRequest(
                document: requestDocument,
                table: requestTable,
                nodePath: ""
            );
            var actual = await this.WordsApi.InsertTableOnline(request);
        }

        /// <summary>
        /// Test for adding table without node path.
        /// </summary>
        [Test]
        public async Task TestInsertTableWithoutNodePath()
        {
            string remoteFileName = "TestInsertTableWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestTable = new TableInsert()
            {
                ColumnsCount = 5,
                RowsCount = 4
            };
            var request = new InsertTableRequest(
                name: remoteFileName,
                table: requestTable,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertTable(request);
            Assert.NotNull(actual.Table);
            Assert.NotNull(actual.Table.TableRowList);
            Assert.AreEqual(4, actual.Table.TableRowList.Count);
            Assert.NotNull(actual.Table.TableRowList[0].TableCellList);
            Assert.AreEqual(5, actual.Table.TableRowList[0].TableCellList.Count);
        }

        /// <summary>
        /// Test for getting document properties.
        /// </summary>
        [Test]
        public async Task TestGetTableProperties()
        {
            string remoteFileName = "TestGetTableProperties.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTablePropertiesRequest(
                name: remoteFileName,
                index: 1,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTableProperties(request);
            Assert.NotNull(actual.Properties);
            Assert.AreEqual("Table Grid", actual.Properties.StyleName);
        }

        /// <summary>
        /// Test for getting document properties online.
        /// </summary>
        [Test]
        public async Task TestGetTablePropertiesOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTablePropertiesOnlineRequest(
                document: requestDocument,
                index: 1,
                nodePath: ""
            );
            var actual = await this.WordsApi.GetTablePropertiesOnline(request);
        }

        /// <summary>
        /// Test for getting document properties without node path.
        /// </summary>
        [Test]
        public async Task TestGetTablePropertiesWithoutNodePath()
        {
            string remoteFileName = "TestGetTablePropertiesWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTablePropertiesRequest(
                name: remoteFileName,
                index: 1,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTableProperties(request);
            Assert.NotNull(actual.Properties);
            Assert.AreEqual("Table Grid", actual.Properties.StyleName);
        }

        /// <summary>
        /// Test for updating table properties.
        /// </summary>
        [Test]
        public async Task TestUpdateTableProperties()
        {
            string remoteFileName = "TestUpdateTableProperties.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestProperties = new TableProperties()
            {
                Alignment = TableProperties.AlignmentEnum.Right,
                AllowAutoFit = false,
                Bidi = true,
                BottomPadding = 1f,
                CellSpacing = 2.0f,
                StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
            };
            var request = new UpdateTablePropertiesRequest(
                name: remoteFileName,
                index: 1,
                properties: requestProperties,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateTableProperties(request);
            Assert.NotNull(actual.Properties);
            Assert.AreEqual(false, actual.Properties.AllowAutoFit);
            Assert.AreEqual(true, actual.Properties.Bidi);
            Assert.AreEqual(1.0f, actual.Properties.BottomPadding);
            Assert.AreEqual(2.0f, actual.Properties.CellSpacing);
        }

        /// <summary>
        /// Test for updating table properties online.
        /// </summary>
        [Test]
        public async Task TestUpdateTablePropertiesOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestProperties = new TableProperties()
            {
                Alignment = TableProperties.AlignmentEnum.Right,
                AllowAutoFit = false,
                Bidi = true,
                BottomPadding = 1f,
                CellSpacing = 2f,
                StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
            };
            var request = new UpdateTablePropertiesOnlineRequest(
                document: requestDocument,
                properties: requestProperties,
                index: 1,
                nodePath: ""
            );
            var actual = await this.WordsApi.UpdateTablePropertiesOnline(request);
        }

        /// <summary>
        /// Test for updating table properties without node path.
        /// </summary>
        [Test]
        public async Task TestUpdateTablePropertiesWithoutNodePath()
        {
            string remoteFileName = "TestUpdateTablePropertiesWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestProperties = new TableProperties()
            {
                Alignment = TableProperties.AlignmentEnum.Right,
                AllowAutoFit = false,
                Bidi = true,
                BottomPadding = 1.0f,
                CellSpacing = 2.0f,
                StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
            };
            var request = new UpdateTablePropertiesRequest(
                name: remoteFileName,
                index: 1,
                properties: requestProperties,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateTableProperties(request);
            Assert.NotNull(actual.Properties);
            Assert.AreEqual(false, actual.Properties.AllowAutoFit);
            Assert.AreEqual(true, actual.Properties.Bidi);
            Assert.AreEqual(1.0f, actual.Properties.BottomPadding);
            Assert.AreEqual(2.0f, actual.Properties.CellSpacing);
        }

        /// <summary>
        /// Test for getting table row.
        /// </summary>
        [Test]
        public async Task TestGetTableRow()
        {
            string remoteFileName = "TestGetTableRow.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTableRowRequest(
                name: remoteFileName,
                tablePath: "tables/1",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTableRow(request);
            Assert.NotNull(actual.Row);
            Assert.NotNull(actual.Row.TableCellList);
            Assert.AreEqual(2, actual.Row.TableCellList.Count);
        }

        /// <summary>
        /// Test for getting table row online.
        /// </summary>
        [Test]
        public async Task TestGetTableRowOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableRowOnlineRequest(
                document: requestDocument,
                tablePath: "tables/1",
                index: 0
            );
            var actual = await this.WordsApi.GetTableRowOnline(request);
        }

        /// <summary>
        /// Test for deleting table row.
        /// </summary>
        [Test]
        public async Task TestDeleteTableRow()
        {
            string remoteFileName = "TestDeleteTableRow.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteTableRowRequest(
                name: remoteFileName,
                tablePath: "tables/1",
                index: 0,
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteTableRow(request);
        }

        /// <summary>
        /// Test for deleting table row online.
        /// </summary>
        [Test]
        public async Task TestDeleteTableRowOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteTableRowOnlineRequest(
                document: requestDocument,
                tablePath: "tables/1",
                index: 0
            );
            var actual = await this.WordsApi.DeleteTableRowOnline(request);
        }

        /// <summary>
        /// Test for adding row.
        /// </summary>
        [Test]
        public async Task TestInsertTableRow()
        {
            string remoteFileName = "TestInsertTableRow.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestRow = new TableRowInsert()
            {
                ColumnsCount = 5
            };
            var request = new InsertTableRowRequest(
                name: remoteFileName,
                row: requestRow,
                nodePath: "sections/0/tables/2",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertTableRow(request);
            Assert.NotNull(actual.Row);
            Assert.NotNull(actual.Row.TableCellList);
            Assert.AreEqual(5, actual.Row.TableCellList.Count);
        }

        /// <summary>
        /// Test for adding row online.
        /// </summary>
        [Test]
        public async Task TestInsertTableRowOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestRow = new TableRowInsert()
            {
                ColumnsCount = 5
            };
            var request = new InsertTableRowOnlineRequest(
                document: requestDocument,
                row: requestRow,
                nodePath: "sections/0/tables/2"
            );
            var actual = await this.WordsApi.InsertTableRowOnline(request);
        }

        /// <summary>
        /// Test for getting row format.
        /// </summary>
        [Test]
        public async Task TestGetTableRowFormat()
        {
            string remoteFileName = "TestGetTableRowFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTableRowFormatRequest(
                name: remoteFileName,
                tablePath: "sections/0/tables/2",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTableRowFormat(request);
            Assert.NotNull(actual.RowFormat);
            Assert.AreEqual(true, actual.RowFormat.AllowBreakAcrossPages);
        }

        /// <summary>
        /// Test for getting row format online.
        /// </summary>
        [Test]
        public async Task TestGetTableRowFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableRowFormatOnlineRequest(
                document: requestDocument,
                tablePath: "sections/0/tables/2",
                index: 0
            );
            var actual = await this.WordsApi.GetTableRowFormatOnline(request);
        }

        /// <summary>
        /// Test updating row format.
        /// </summary>
        [Test]
        public async Task TestUpdateTableRowFormat()
        {
            string remoteFileName = "TestUpdateTableRowFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestFormat = new TableRowFormat()
            {
                AllowBreakAcrossPages = true,
                HeadingFormat = true,
                Height = 10.0f,
                HeightRule = TableRowFormat.HeightRuleEnum.Exactly
            };
            var request = new UpdateTableRowFormatRequest(
                name: remoteFileName,
                tablePath: "sections/0/tables/2",
                index: 0,
                format: requestFormat,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateTableRowFormat(request);
            Assert.NotNull(actual.RowFormat);
            Assert.AreEqual(true, actual.RowFormat.AllowBreakAcrossPages);
            Assert.AreEqual(true, actual.RowFormat.HeadingFormat);
            Assert.AreEqual(10.0f, actual.RowFormat.Height);
        }

        /// <summary>
        /// Test updating row format online.
        /// </summary>
        [Test]
        public async Task TestUpdateTableRowFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestFormat = new TableRowFormat()
            {
                AllowBreakAcrossPages = true,
                HeadingFormat = true,
                Height = 10f,
                HeightRule = TableRowFormat.HeightRuleEnum.Auto
            };
            var request = new UpdateTableRowFormatOnlineRequest(
                document: requestDocument,
                tablePath: "sections/0/tables/2",
                format: requestFormat,
                index: 0
            );
            var actual = await this.WordsApi.UpdateTableRowFormatOnline(request);
        }

        /// <summary>
        /// Test for getting table cell.
        /// </summary>
        [Test]
        public async Task TestGetTableCell()
        {
            string remoteFileName = "TestGetTableCell.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTableCellRequest(
                name: remoteFileName,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTableCell(request);
            Assert.NotNull(actual.Cell);
            Assert.AreEqual("0.0.5.0.0", actual.Cell.NodeId);
        }

        /// <summary>
        /// Test for getting table cell online.
        /// </summary>
        [Test]
        public async Task TestGetTableCellOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableCellOnlineRequest(
                document: requestDocument,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0
            );
            var actual = await this.WordsApi.GetTableCellOnline(request);
        }

        /// <summary>
        /// Test for deleting cell.
        /// </summary>
        [Test]
        public async Task TestDeleteTableCell()
        {
            string remoteFileName = "TestDeleteTableCell.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new DeleteTableCellRequest(
                name: remoteFileName,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0,
                folder: remoteDataFolder
            );
        await this.WordsApi.DeleteTableCell(request);
        }

        /// <summary>
        /// Test for deleting cell online.
        /// </summary>
        [Test]
        public async Task TestDeleteTableCellOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteTableCellOnlineRequest(
                document: requestDocument,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0
            );
            var actual = await this.WordsApi.DeleteTableCellOnline(request);
        }

        /// <summary>
        /// Test for adding cell.
        /// </summary>
        [Test]
        public async Task TestInsertTableCell()
        {
            string remoteFileName = "TestInsertTableCell.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestCell = new TableCellInsert()
            {
            };
            var request = new InsertTableCellRequest(
                name: remoteFileName,
                cell: requestCell,
                tableRowPath: "sections/0/tables/2/rows/0",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.InsertTableCell(request);
            Assert.NotNull(actual.Cell);
            Assert.AreEqual("0.0.5.0.3", actual.Cell.NodeId);
        }

        /// <summary>
        /// Test for adding cell online.
        /// </summary>
        [Test]
        public async Task TestInsertTableCellOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestCell = new TableCellInsert()
            {
            };
            var request = new InsertTableCellOnlineRequest(
                document: requestDocument,
                cell: requestCell,
                tableRowPath: "sections/0/tables/2/rows/0"
            );
            var actual = await this.WordsApi.InsertTableCellOnline(request);
        }

        /// <summary>
        /// Test for getting cell format.
        /// </summary>
        [Test]
        public async Task TestGetTableCellFormat()
        {
            string remoteFileName = "TestGetTableCellFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTableCellFormatRequest(
                name: remoteFileName,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetTableCellFormat(request);
            Assert.NotNull(actual.CellFormat);
            Assert.AreEqual(true, actual.CellFormat.WrapText);
        }

        /// <summary>
        /// Test for getting cell format online.
        /// </summary>
        [Test]
        public async Task TestGetTableCellFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableCellFormatOnlineRequest(
                document: requestDocument,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0
            );
            var actual = await this.WordsApi.GetTableCellFormatOnline(request);
        }

        /// <summary>
        /// Test for updating cell format.
        /// </summary>
        [Test]
        public async Task TestUpdateTableCellFormat()
        {
            string remoteFileName = "TestUpdateTableCellFormat.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestFormat = new TableCellFormat()
            {
                BottomPadding = 5.0f,
                FitText = true,
                HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First,
                WrapText = true
            };
            var request = new UpdateTableCellFormatRequest(
                name: remoteFileName,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0,
                format: requestFormat,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.UpdateTableCellFormat(request);
            Assert.NotNull(actual.CellFormat);
            Assert.AreEqual(5.0f, actual.CellFormat.BottomPadding);
            Assert.AreEqual(true, actual.CellFormat.FitText);
            Assert.AreEqual(true, actual.CellFormat.WrapText);
        }

        /// <summary>
        /// Test for updating cell format online.
        /// </summary>
        [Test]
        public async Task TestUpdateTableCellFormatOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestFormat = new TableCellFormat()
            {
                BottomPadding = 5f,
                FitText = true,
                HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First,
                WrapText = true
            };
            var request = new UpdateTableCellFormatOnlineRequest(
                document: requestDocument,
                tableRowPath: "sections/0/tables/2/rows/0",
                format: requestFormat,
                index: 0
            );
            var actual = await this.WordsApi.UpdateTableCellFormatOnline(request);
        }

        /// <summary>
        /// Test for table rendering.
        /// </summary>
        [Test]
        public async Task TestRenderTable()
        {
            string remoteFileName = "TestRenderTable.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderTableRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.RenderTable(request);
        }

        /// <summary>
        /// Test for table rendering.
        /// </summary>
        [Test]
        public async Task TestRenderTableOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new RenderTableOnlineRequest(
                document: requestDocument,
                format: "png",
                index: 0,
                nodePath: ""
            );
            var actual = await this.WordsApi.RenderTableOnline(request);
        }

        /// <summary>
        /// Test for table rendering without node path.
        /// </summary>
        [Test]
        public async Task TestRenderTableWithoutNodePath()
        {
            string remoteFileName = "TestRenderTableWithoutNodePath.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new RenderTableRequest(
                name: remoteFileName,
                format: "png",
                index: 0,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.RenderTable(request);
        }
    }
}
