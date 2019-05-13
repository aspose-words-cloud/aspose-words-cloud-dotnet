// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="TableBorderTest.cs">
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
    /// Example of how to work with table borders
    /// <remarks>These methods are applicable to cells and rows</remarks>
    /// </summary>
    [TestFixture]
    public class TableBorderTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Tables");

        private readonly string tableFolder = "DocumentElements/Tables/";

        /// <summary>
        /// Test for getting borders
        /// </summary>
        [Test]
        public void TestGetTableBorders()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableBorders.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetBordersRequest(remoteName, "tables/1/rows/0/cells/0/", this.dataFolder);
            var actual = this.WordsApi.GetBorders(request);
        }

        /// <summary>
        /// Test for getting border
        /// </summary>
        [Test]
        public void TestGetTableBorder()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestGetTableBorder.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new GetBorderRequest(remoteName, "tables/1/rows/0/cells/0/", 0, this.dataFolder);
            var actual = this.WordsApi.GetBorder(request);
        }

        /// <summary>
        /// Test for deleting borders
        /// </summary>
        [Test]
        public void TestDeleteTableBorders()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTableBorders.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteBordersRequest(remoteName, "tables/1/rows/0/cells/0/", this.dataFolder);
            var actual = this.WordsApi.DeleteBorders(request);
        }

        /// <summary>
        /// Test for deleting border
        /// </summary>
        [Test]
        public void TestDeleteTableBorder()
        {
            var localName = "TablesGet.docx";
            var remoteName = "TestDeleteTableBorder.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new DeleteBorderRequest(remoteName, "tables/1/rows/0/cells/0/", 0, this.dataFolder);
            var actual = this.WordsApi.DeleteBorder(request);
        }

        /// <summary>
        /// Test for updating border
        /// </summary>
        [Test]
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

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.tableFolder) + localName));

            var request = new UpdateBorderRequest(remoteName, border, "tables/1/rows/0/cells/0/", 0, this.dataFolder);
            var actual = this.WordsApi.UpdateBorder(request);
        }
    }
}