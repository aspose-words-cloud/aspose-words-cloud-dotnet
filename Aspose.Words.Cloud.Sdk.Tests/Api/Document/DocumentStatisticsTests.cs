// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentStatisticsTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Document
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to get document statistics.
    /// </summary>
    [TestFixture]
    public class DocumentStatisticsTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/Statistics";
        private readonly string localFile = "Common/test_multi_pages.docx";

        /// <summary>
        /// Test for document classification.
        /// </summary>
        [Test]
        public async Task TestGetDocumentStatistics()
        {
            string remoteFileName = "TestGetDocumentStatistics.docx";

            await this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request = new GetDocumentStatisticsRequest(
                name: remoteFileName,
                folder: remoteDataFolder
            );
            var actual = await this.WordsApi.GetDocumentStatistics(request);
            Assert.NotNull(actual.StatData);
            Assert.AreEqual(10, actual.StatData.WordCount);
        }

        /// <summary>
        /// Test for document classification online.
        /// </summary>
        [Test]
        public async Task TestGetDocumentStatisticsOnline()
        {
            using var requestDocument = File.OpenRead(LocalTestDataFolder + localFile);
            var request = new GetDocumentStatisticsOnlineRequest(
                document: requestDocument
            );
            var actual = await this.WordsApi.GetDocumentStatisticsOnline(request);
        }
    }
}
