// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextTests.cs">
//   Copyright (c) 2024 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Text
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with macros.
    /// </summary>
    [TestFixture]
    public class TextTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Text";

        /// <summary>
        /// Test for replacing text.
        /// </summary>
        [Test]
        public async Task TestReplaceText()
        {
            string remoteFileName = "TestReplaceText.docx";
            string localFile = "Common/test_multi_pages.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var requestReplaceText = new ReplaceTextParameters()
            {
                OldValue = "Testing",
                NewValue = "Aspose testing",
                IsMatchCase = true,
                IsMatchWholeWord = false,
                IsOldValueRegex = false
            };
            var request = new ReplaceTextRequest(
                name: remoteFileName,
                replaceText: requestReplaceText,
                folder: remoteDataFolder,
                destFileName: BaseTestOutPath + "/" + remoteFileName
            );
            var actual = await this.WordsApi.ReplaceText(request);
            Assert.AreEqual(3, actual.Matches);
        }

        /// <summary>
        /// Test for replacing text online.
        /// </summary>
        [Test]
        public async Task TestReplaceTextOnline()
        {
            string localFile = "Common/test_multi_pages.docx";

            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var requestReplaceText = new ReplaceTextParameters()
            {
                OldValue = "aspose",
                NewValue = "aspose new",
                IsMatchCase = true,
                IsMatchWholeWord = false,
                IsOldValueRegex = false
            };
            var request = new ReplaceTextOnlineRequest(
                document: requestDocument,
                replaceText: requestReplaceText
            );
            var actual = await this.WordsApi.ReplaceTextOnline(request);
        }

        /// <summary>
        /// Test for searching.
        /// </summary>
        [Test]
        public async Task TestSearch()
        {
            string remoteFileName = "TestSearch.docx";
            string localFile = "DocumentElements/Text/SampleWordDocument.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new SearchRequest(
                name: remoteFileName,
                pattern: "aspose",
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.Search(request);
            Assert.NotNull(actual.SearchResults);
            Assert.NotNull(actual.SearchResults.ResultsList);
            Assert.AreEqual(23, actual.SearchResults.ResultsList.Count);
            Assert.NotNull(actual.SearchResults.ResultsList[0].RangeStart);
            Assert.AreEqual(65, actual.SearchResults.ResultsList[0].RangeStart.Offset);
        }

        /// <summary>
        /// Test for searching online.
        /// </summary>
        [Test]
        public async Task TestSearchOnline()
        {
            string localFile = "DocumentElements/Text/SampleWordDocument.docx";

            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new SearchOnlineRequest(
                document: requestDocument,
                pattern: "aspose"
            );
            var actual = await this.WordsApi.SearchOnline(request);
        }
    }
}
