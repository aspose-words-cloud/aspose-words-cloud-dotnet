// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="TextTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.Text
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with text
    /// </summary>
    [TestFixture]    
    public class TextTest : BaseTestContext
    {
        private static string textFolder = "DocumentElements/Text";
        private readonly string remoteDataFolder = Path.Combine(RemoteBaseTestDataFolder, textFolder);
        
        /// <summary>
        /// Test for getting text from document
        /// </summary>
        [Test]
        public void TestGetDocumentTextItems()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentTextItems.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentTextItemsRequest(remoteName, this.remoteDataFolder);
            var actual = this.WordsApi.GetDocumentTextItems(request);
        }

        /// <summary>
        /// Test for replacing text
        /// </summary>
        [Test]
        public void TestPostReplaceText()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostReplaceText.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var body = new ReplaceTextParameters { OldValue = "aspose", NewValue = "aspose new" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new ReplaceTextRequest(remoteName, body, this.remoteDataFolder, destFileName: destFileName);
            var actual = this.WordsApi.ReplaceText(request);
        }

        /// <summary>
        /// Test for searching
        /// </summary>
        [Test]
        public void TestSearch()
        {
            var localName = "SampleWordDocument.docx";
            var remoteName = "TestSearch.docx";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            var pattern = "aspose";

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(Path.Combine(BaseTestContext.LocalTestDataFolder, textFolder, localName)));

            var request = new SearchRequest(remoteName, pattern, this.remoteDataFolder);
            var actual = this.WordsApi.Search(request);
        }
    }
}