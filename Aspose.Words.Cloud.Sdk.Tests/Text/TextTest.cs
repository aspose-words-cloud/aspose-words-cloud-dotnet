// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="TextTest.cs">
// //   Copyright (c) 2016 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Tests.Text
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to work with text
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class TextTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "DocumentActions/Text");

        private readonly string textFolder = "Text/";

        /// <summary>
        /// Test for getting text from document
        /// </summary>
        [TestMethod]
        public void TestGetDocumentTextItems()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentTextItems.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentTextItemsRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetDocumentTextItems(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for replacing text
        /// </summary>
        [TestMethod]
        public void TestPostReplaceText()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostReplaceText.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new ReplaceTextRequest { OldValue = "aspose", NewValue = "aspose new" };

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PostReplaceTextRequest(remoteName, body, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.PostReplaceText(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for searching
        /// </summary>
        [TestMethod]
        public void TestSearch()
        {
            var localName = "SampleWordDocument.docx";
            var remoteName = "TestSearch.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var pattern = "aspose";

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.textFolder) + localName));

            var request = new SearchRequest(remoteName, pattern, this.dataFolder);
            var actual = this.WordsApi.Search(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}