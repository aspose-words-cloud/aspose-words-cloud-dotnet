// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="RangeTests.cs">
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
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Tests.Range
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Range related tests
    /// </summary>
    [TestFixture]
    public class RangeTests : BaseTestContext
    {
        private readonly string localDataFolder = "DocumentElements/Range/";
        private readonly string remoteDataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Range/");

        /// <summary>
        /// Test for getting the text from range.
        /// </summary>
        [Test]
        public void GetRangeText()
        {
            var rangeStart = "id0.0.0";
            var rangeEnd = "id0.0.1";
            var expectedText = "This is HEADER ";

            var localName = "RangeGet.doc";
            var remoteName = "TestGetRangeText.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var request = new GetRangeTextRequest(remoteName, rangeStart, rangeEnd, this.remoteDataFolder);
            var rangeTextResponse = this.WordsApi.GetRangeText(request);

            Assert.AreEqual(expectedText, rangeTextResponse.Text);
        }

        /// <summary>
        /// Test for removing the text for range.
        /// </summary>
        [Test]
        public void RemoveRange()
        {
            var localName = "RangeGet.doc";
            var remoteName = "TestRemoveRange.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var rangeStart = "id0.0.0";
            var rangeEnd = "id0.0.1";
            var request = new RemoveRangeRequest(remoteName, rangeStart, rangeEnd, this.remoteDataFolder);
            this.WordsApi.RemoveRange(request);
        }

        /// <summary>
        /// Test for saving a range as a new document.
        /// </summary>
        [Test]
        public void SaveAsRange()
        {
            var localName = "RangeGet.doc";
            var remoteName = "TestSaveAsRange.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var rangeStart = "id0.0.0";
            var rangeEnd = "id0.0.1";
            var newDocName = Path.Combine(this.remoteDataFolder, "NewDoc.docx");
            var rangeDoc = new RangeDocument { DocumentName = newDocName };
            var request = new SaveAsRangeRequest(remoteName, rangeStart, rangeDoc, rangeEnd, this.remoteDataFolder);
            this.WordsApi.SaveAsRange(request);

            var result = this.WordsApi.DownloadFile(new DownloadFileRequest(newDocName));
            Assert.IsNotNull(result, "Cannot download document from storage");
        }

        /// <summary>
        /// Test for replacing text in range
        /// </summary>
        [Test]
        public void ReplaceWithText()
        {
            var localName = "RangeGet.doc";
            var remoteName = "TestSaveAsRange.doc";
            var fullName = Path.Combine(this.remoteDataFolder, remoteName);
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.localDataFolder) + localName));

            var rangeStart = "id0.0.0";
            var rangeEnd = "id0.0.1";
            var newText = "Replaced header";
            var replacement = new ReplaceRange { Text = newText };
            var request = new ReplaceWithTextRequest(remoteName, rangeStart, replacement, rangeEnd, this.remoteDataFolder);
            this.WordsApi.ReplaceWithText(request);
        }
    }
}
