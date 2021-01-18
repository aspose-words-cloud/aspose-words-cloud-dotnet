// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableTests.cs">
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
        public void TestGetTables()
        {
            string remoteFileName = "TestGetTables.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTables(request);
            Assert.NotNull(actual.Tables);
            Assert.NotNull(actual.Tables.TableLinkList);
            Assert.AreEqual(5, actual.Tables.TableLinkList.Count);
            Assert.AreEqual("0.0.1", actual.Tables.TableLinkList[0].NodeId);
        }

        /// <summary>
        /// Test for getting tables online.
        /// </summary>
        [Test]
        public void TestGetTablesOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTablesOnlineRequest(
                document: document,
                nodePath: ""
            );
             var actual = this.WordsApi.GetTablesOnline(request);
        }

        /// <summary>
        /// Test for getting tables without node path.
        /// </summary>
        [Test]
        public void TestGetTablesWithoutNodePath()
        {
            string remoteFileName = "TestGetTablesWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetTablesRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.GetTables(request);
            Assert.NotNull(actual.Tables);
            Assert.NotNull(actual.Tables.TableLinkList);
            Assert.AreEqual(5, actual.Tables.TableLinkList.Count);
            Assert.AreEqual("0.0.1", actual.Tables.TableLinkList[0].NodeId);
        }

        /// <summary>
        /// Test for getting table.
        /// </summary>
        [Test]
        public void TestGetTable()
        {
            string remoteFileName = "TestGetTable.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTable(request);
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
        public void TestGetTableOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableOnlineRequest(
                document: document,
                index: 1,
                nodePath: ""
            );
             var actual = this.WordsApi.GetTableOnline(request);
        }

        /// <summary>
        /// Test for getting table without node path.
        /// </summary>
        [Test]
        public void TestGetTableWithoutNodePath()
        {
            string remoteFileName = "TestGetTableWithoutNodePath.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTable(request);
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
        public void TestDeleteTable()
        {
            string remoteFileName = "TestDeleteTable.docx";

            this.UploadFileToStorage(
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

             this.WordsApi.DeleteTable(request);
        }

        /// <summary>
        /// Test for deleting table online.
        /// </summary>
        [Test]
        public void TestDeleteTableOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteTableOnlineRequest(
                document: document,
                index: 1,
                nodePath: ""
            );
             var actual = this.WordsApi.DeleteTableOnline(request);
        }

        /// <summary>
        /// Test for deleting table without node path.
        /// </summary>
        [Test]
        public void TestDeleteTableWithoutNodePath()
        {
            string remoteFileName = "TestDeleteTableWithoutNodePath.docx";

            this.UploadFileToStorage(
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

             this.WordsApi.DeleteTable(request);
        }

        /// <summary>
        /// Test for adding table.
        /// </summary>
        [Test]
        public void TestInsertTable()
        {
            string remoteFileName = "TestInsertTable.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertTableRequest(
                name: remoteFileName,
                table: new TableInsert()
                {
                    ColumnsCount = 5,
                    RowsCount = 4
                },
                nodePath: "",
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.InsertTable(request);
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
        public void TestInsertTableOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertTableOnlineRequest(
                document: document,
                table: new TableInsert()
                {
                    ColumnsCount = 5,
                    RowsCount = 4
                },
                nodePath: ""
            );
             var actual = this.WordsApi.InsertTableOnline(request);
        }

        /// <summary>
        /// Test for adding table without node path.
        /// </summary>
        [Test]
        public void TestInsertTableWithoutNodePath()
        {
            string remoteFileName = "TestInsertTableWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertTableRequest(
                name: remoteFileName,
                table: new TableInsert()
                {
                    ColumnsCount = 5,
                    RowsCount = 4
                },
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.InsertTable(request);
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
        public void TestGetTableProperties()
        {
            string remoteFileName = "TestGetTableProperties.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTableProperties(request);
            Assert.NotNull(actual.Properties);
            Assert.AreEqual("Table Grid", actual.Properties.StyleName);
        }

        /// <summary>
        /// Test for getting document properties online.
        /// </summary>
        [Test]
        public void TestGetTablePropertiesOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTablePropertiesOnlineRequest(
                document: document,
                index: 1,
                nodePath: ""
            );
             var actual = this.WordsApi.GetTablePropertiesOnline(request);
        }

        /// <summary>
        /// Test for getting document properties without node path.
        /// </summary>
        [Test]
        public void TestGetTablePropertiesWithoutNodePath()
        {
            string remoteFileName = "TestGetTablePropertiesWithoutNodePath.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTableProperties(request);
            Assert.NotNull(actual.Properties);
            Assert.AreEqual("Table Grid", actual.Properties.StyleName);
        }

        /// <summary>
        /// Test for updating table properties.
        /// </summary>
        [Test]
        public void TestUpdateTableProperties()
        {
            string remoteFileName = "TestUpdateTableProperties.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateTablePropertiesRequest(
                name: remoteFileName,
                properties: new TableProperties()
                {
                    Alignment = TableProperties.AlignmentEnum.Right,
                    AllowAutoFit = false,
                    Bidi = true,
                    BottomPadding = 1f,
                    CellSpacing = 2.0f,
                    StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
                },
                index: 1,
                nodePath: "",
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.UpdateTableProperties(request);
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
        public void TestUpdateTablePropertiesOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateTablePropertiesOnlineRequest(
                document: document,
                properties: new TableProperties()
                {
                    Alignment = TableProperties.AlignmentEnum.Right,
                    AllowAutoFit = false,
                    Bidi = true,
                    BottomPadding = 1f,
                    CellSpacing = 2f,
                    StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
                },
                index: 1,
                nodePath: ""
            );
             var actual = this.WordsApi.UpdateTablePropertiesOnline(request);
        }

        /// <summary>
        /// Test for updating table properties without node path.
        /// </summary>
        [Test]
        public void TestUpdateTablePropertiesWithoutNodePath()
        {
            string remoteFileName = "TestUpdateTablePropertiesWithoutNodePath.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateTablePropertiesRequest(
                name: remoteFileName,
                properties: new TableProperties()
                {
                    Alignment = TableProperties.AlignmentEnum.Right,
                    AllowAutoFit = false,
                    Bidi = true,
                    BottomPadding = 1.0f,
                    CellSpacing = 2.0f,
                    StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
                },
                index: 1,
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.UpdateTableProperties(request);
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
        public void TestGetTableRow()
        {
            string remoteFileName = "TestGetTableRow.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTableRow(request);
            Assert.NotNull(actual.Row);
            Assert.NotNull(actual.Row.TableCellList);
            Assert.AreEqual(2, actual.Row.TableCellList.Count);
        }

        /// <summary>
        /// Test for getting table row online.
        /// </summary>
        [Test]
        public void TestGetTableRowOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableRowOnlineRequest(
                document: document,
                tablePath: "tables/1",
                index: 0
            );
             var actual = this.WordsApi.GetTableRowOnline(request);
        }

        /// <summary>
        /// Test for deleting table row.
        /// </summary>
        [Test]
        public void TestDeleteTableRow()
        {
            string remoteFileName = "TestDeleteTableRow.docx";

            this.UploadFileToStorage(
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

             this.WordsApi.DeleteTableRow(request);
        }

        /// <summary>
        /// Test for deleting table row online.
        /// </summary>
        [Test]
        public void TestDeleteTableRowOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteTableRowOnlineRequest(
                document: document,
                tablePath: "tables/1",
                index: 0
            );
             var actual = this.WordsApi.DeleteTableRowOnline(request);
        }

        /// <summary>
        /// Test for adding row.
        /// </summary>
        [Test]
        public void TestInsertTableRow()
        {
            string remoteFileName = "TestInsertTableRow.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertTableRowRequest(
                name: remoteFileName,
                row: new TableRowInsert()
                {
                    ColumnsCount = 5
                },
                tablePath: "sections/0/tables/2",
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.InsertTableRow(request);
            Assert.NotNull(actual.Row);
            Assert.NotNull(actual.Row.TableCellList);
            Assert.AreEqual(5, actual.Row.TableCellList.Count);
        }

        /// <summary>
        /// Test for adding row online.
        /// </summary>
        [Test]
        public void TestInsertTableRowOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertTableRowOnlineRequest(
                document: document,
                row: new TableRowInsert()
                {
                    ColumnsCount = 5
                },
                tablePath: "sections/0/tables/2"
            );
             var actual = this.WordsApi.InsertTableRowOnline(request);
        }

        /// <summary>
        /// Test for getting row format.
        /// </summary>
        [Test]
        public void TestGetTableRowFormat()
        {
            string remoteFileName = "TestGetTableRowFormat.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTableRowFormat(request);
            Assert.NotNull(actual.RowFormat);
            Assert.AreEqual(true, actual.RowFormat.AllowBreakAcrossPages);
        }

        /// <summary>
        /// Test for getting row format online.
        /// </summary>
        [Test]
        public void TestGetTableRowFormatOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableRowFormatOnlineRequest(
                document: document,
                tablePath: "sections/0/tables/2",
                index: 0
            );
             var actual = this.WordsApi.GetTableRowFormatOnline(request);
        }

        /// <summary>
        /// Test updating row format.
        /// </summary>
        [Test]
        public void TestUpdateTableRowFormat()
        {
            string remoteFileName = "TestUpdateTableRowFormat.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateTableRowFormatRequest(
                name: remoteFileName,
                format: new TableRowFormat()
                {
                    AllowBreakAcrossPages = true,
                    HeadingFormat = true,
                    Height = 10.0f,
                    HeightRule = TableRowFormat.HeightRuleEnum.Exactly
                },
                tablePath: "sections/0/tables/2",
                index: 0,
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.UpdateTableRowFormat(request);
            Assert.NotNull(actual.RowFormat);
            Assert.AreEqual(true, actual.RowFormat.AllowBreakAcrossPages);
            Assert.AreEqual(true, actual.RowFormat.HeadingFormat);
            Assert.AreEqual(10.0f, actual.RowFormat.Height);
        }

        /// <summary>
        /// Test updating row format online.
        /// </summary>
        [Test]
        public void TestUpdateTableRowFormatOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateTableRowFormatOnlineRequest(
                document: document,
                format: new TableRowFormat()
                {
                    AllowBreakAcrossPages = true,
                    HeadingFormat = true,
                    Height = 10f,
                    HeightRule = TableRowFormat.HeightRuleEnum.Auto
                },
                tablePath: "sections/0/tables/2",
                index: 0
            );
             var actual = this.WordsApi.UpdateTableRowFormatOnline(request);
        }

        /// <summary>
        /// Test for getting table cell.
        /// </summary>
        [Test]
        public void TestGetTableCell()
        {
            string remoteFileName = "TestGetTableCell.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTableCell(request);
            Assert.NotNull(actual.Cell);
            Assert.AreEqual("0.0.5.0.0", actual.Cell.NodeId);
        }

        /// <summary>
        /// Test for getting table cell online.
        /// </summary>
        [Test]
        public void TestGetTableCellOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableCellOnlineRequest(
                document: document,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0
            );
             var actual = this.WordsApi.GetTableCellOnline(request);
        }

        /// <summary>
        /// Test for deleting cell.
        /// </summary>
        [Test]
        public void TestDeleteTableCell()
        {
            string remoteFileName = "TestDeleteTableCell.docx";

            this.UploadFileToStorage(
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

             this.WordsApi.DeleteTableCell(request);
        }

        /// <summary>
        /// Test for deleting cell online.
        /// </summary>
        [Test]
        public void TestDeleteTableCellOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new DeleteTableCellOnlineRequest(
                document: document,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0
            );
             var actual = this.WordsApi.DeleteTableCellOnline(request);
        }

        /// <summary>
        /// Test for adding cell.
        /// </summary>
        [Test]
        public void TestInsertTableCell()
        {
            string remoteFileName = "TestInsertTableCell.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new InsertTableCellRequest(
                name: remoteFileName,
                cell: new TableCellInsert()
                {
                },
                tableRowPath: "sections/0/tables/2/rows/0",
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.InsertTableCell(request);
            Assert.NotNull(actual.Cell);
            Assert.AreEqual("0.0.5.0.3", actual.Cell.NodeId);
        }

        /// <summary>
        /// Test for adding cell online.
        /// </summary>
        [Test]
        public void TestInsertTableCellOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new InsertTableCellOnlineRequest(
                document: document,
                cell: new TableCellInsert()
                {
                },
                tableRowPath: "sections/0/tables/2/rows/0"
            );
             var actual = this.WordsApi.InsertTableCellOnline(request);
        }

        /// <summary>
        /// Test for getting cell format.
        /// </summary>
        [Test]
        public void TestGetTableCellFormat()
        {
            string remoteFileName = "TestGetTableCellFormat.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.GetTableCellFormat(request);
            Assert.NotNull(actual.CellFormat);
            Assert.AreEqual(true, actual.CellFormat.WrapText);
        }

        /// <summary>
        /// Test for getting cell format online.
        /// </summary>
        [Test]
        public void TestGetTableCellFormatOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetTableCellFormatOnlineRequest(
                document: document,
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0
            );
             var actual = this.WordsApi.GetTableCellFormatOnline(request);
        }

        /// <summary>
        /// Test for updating cell format.
        /// </summary>
        [Test]
        public void TestUpdateTableCellFormat()
        {
            string remoteFileName = "TestUpdateTableCellFormat.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new UpdateTableCellFormatRequest(
                name: remoteFileName,
                format: new TableCellFormat()
                {
                    BottomPadding = 5.0f,
                    FitText = true,
                    HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First,
                    WrapText = true
                },
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0,
                folder: remoteDataFolder
            );

             var actual = this.WordsApi.UpdateTableCellFormat(request);
            Assert.NotNull(actual.CellFormat);
            Assert.AreEqual(5.0f, actual.CellFormat.BottomPadding);
            Assert.AreEqual(true, actual.CellFormat.FitText);
            Assert.AreEqual(true, actual.CellFormat.WrapText);
        }

        /// <summary>
        /// Test for updating cell format online.
        /// </summary>
        [Test]
        public void TestUpdateTableCellFormatOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new UpdateTableCellFormatOnlineRequest(
                document: document,
                format: new TableCellFormat()
                {
                    BottomPadding = 5f,
                    FitText = true,
                    HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First,
                    WrapText = true
                },
                tableRowPath: "sections/0/tables/2/rows/0",
                index: 0
            );
             var actual = this.WordsApi.UpdateTableCellFormatOnline(request);
        }

        /// <summary>
        /// Test for table rendering.
        /// </summary>
        [Test]
        public void TestRenderTable()
        {
            string remoteFileName = "TestRenderTable.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.RenderTable(request);
        }

        /// <summary>
        /// Test for table rendering.
        /// </summary>
        [Test]
        public void TestRenderTableOnline()
        {
            using var document = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new RenderTableOnlineRequest(
                document: document,
                format: "png",
                index: 0,
                nodePath: ""
            );
             var actual = this.WordsApi.RenderTableOnline(request);
        }

        /// <summary>
        /// Test for table rendering without node path.
        /// </summary>
        [Test]
        public void TestRenderTableWithoutNodePath()
        {
            string remoteFileName = "TestRenderTableWithoutNodePath.docx";

            this.UploadFileToStorage(
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

             var actual = this.WordsApi.RenderTable(request);
        }
    }
}
