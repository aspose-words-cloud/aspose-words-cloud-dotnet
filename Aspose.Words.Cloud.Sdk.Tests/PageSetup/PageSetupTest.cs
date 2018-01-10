// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="PageSetupTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.PageSetup
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to work with page settings
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class PageSetupTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentElements/PageSetup");

        private readonly string textFolder = "Text/";

        /// <summary>
        /// Test for getting page settings
        /// </summary>
        [TestMethod]
        public void TestGetSectionPageSetup()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetSectionPageSetup.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var sectionIndex = 0;

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetSectionPageSetupRequest(remoteName, sectionIndex, this.dataFolder);
            var actual = this.WordsApi.GetSectionPageSetup(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for updating page settings
        /// </summary>
        [TestMethod]
        public void TestUpdateSectionPageSetup()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestUpdateSectionPageSetup.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var sectionIndex = 0;

            var body = new PageSetup
                           {
                               RtlGutter = true,
                               LeftMargin = 10.0f,
                               Orientation = PageSetup.OrientationEnum.Landscape,
                               PaperSize = PageSetup.PaperSizeEnum.A5
                           };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new UpdateSectionPageSetupRequest(remoteName, sectionIndex, body, this.dataFolder);
            var actual = this.WordsApi.UpdateSectionPageSetup(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for page rendering
        /// </summary>
        [TestMethod]
        public void TestGetRenderPage()
        {
            var localName = "SampleWordDocument.docx";
            var remoteName = "TestGetRenderPage.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var pageNumber = 1;
            var format = "bmp";

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.textFolder) + localName));

            var request = new RenderPageRequest(remoteName, pageNumber, format, this.dataFolder);
            var result = this.WordsApi.RenderPage(request);

            Assert.IsTrue(result.Length > 0, "Error while page render");
        }
    }
}