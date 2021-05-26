// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BatchTests.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests
{
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Tests of batch requests
    /// </summary>
    [TestFixture]
    public class BatchTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentElements/Paragraphs";
        private readonly string localFile = "Common/test_multi_pages.docx";
        private readonly string reportingFolder = "DocumentActions/Reporting";

        /// <summary>
        /// Check of multiple paragraph operations.
        /// </summary>
        [Test]
        public void TestBatchParagraphs()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndex.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null, null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var batch = new List<IRequestModel>();

            batch.Add(new GetParagraphsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            ));

            batch.Add(new GetParagraphRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            ));

            batch.Add(new InsertParagraphRequest(
                name: remoteFileName,
                paragraph: new ParagraphInsert()
                {
                    Text = "This is a new paragraph for your document"
                },
                nodePath: "sections/0",
                folder: remoteDataFolder
            ));

            batch.Add(new DeleteParagraphRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "",
                folder: remoteDataFolder
            ));

            string localDocumentFile = "ReportTemplate.docx";
            string localDataFile = File.ReadAllText(LocalTestDataFolder + reportingFolder + "/ReportData.json");

            batch.Add(new BuildReportOnlineRequest(
                template: File.OpenRead(LocalTestDataFolder + reportingFolder + "/" + localDocumentFile),
                data: localDataFile,
                reportEngineSettings: new ReportEngineSettings()
                {
                    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
                    DataSourceName = "persons"
                }
            ));

            var actual = this.WordsApi.Batch(batch.Select(x => new BatchPartRequest(x)).ToArray());
            Assert.IsTrue(actual.Length == 5);
            Assert.IsTrue(actual[0] is ParagraphLinkCollectionResponse); // GetParagraphs
            Assert.IsTrue(actual[1] is ParagraphResponse); // GetParagraph
            Assert.IsTrue(actual[2] is ParagraphResponse); // InsertParagraph
            Assert.IsTrue(actual[3]  == null); // DeleteParagraph
            Assert.IsTrue(actual[4] is Stream); // BuildReportOnline
        }

        /// <summary>
        /// Check of reversed order of responses.
        /// </summary>
        [Test]
        public void TestBatchWithReversedOrderOfResponses()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndex.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null, null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request1 = new BatchPartRequest(new GetParagraphsRequest(
                name: remoteFileName,
                nodePath: "sections/0",
                folder: remoteDataFolder
            ));

            var request2 = new BatchPartRequest(new GetParagraphRequest(
                name: remoteFileName,
                index: 0,
                nodePath: "sections/0",
                folder: remoteDataFolder
            ));

            request1.DependsOn(request2);

            var actual = this.WordsApi.Batch(request1, request2);
            Assert.IsTrue(actual.Length == 2);

            // Expected order is 2, 1
            Assert.IsTrue(actual[1] is ParagraphLinkCollectionResponse); // GetParagraphs
            Assert.IsTrue(actual[0] is ParagraphResponse); // GetParagraph
        }

        /// <summary>
        /// Check of resultOf feature.
        /// </summary>
        [Test]
        public void TestBatchWithResultOf()
        {
            string remoteFileName = "TestGetDocumentParagraphByIndex.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null, null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request1 = new BatchPartRequest(new GetDocumentWithFormatRequest(
                name: remoteFileName,
                format: "docx",
                folder: remoteDataFolder
            ));

            var request2 = new BatchPartRequest(new DeleteCommentsOnlineRequest(
                document: request1.UseAsSource()
            ));

            request2.DependsOn(request1);

            var actual = this.WordsApi.Batch(request1, request2);
            Assert.IsTrue(actual.Length == 2);
            Assert.IsTrue(actual[1] is Stream); // resulted document stream
        }

        /// <summary>
        /// Node SDK example.
        /// </summary>
        [Test]
        public void TestBatchFromNodeSdk()
        {
            string remoteFileName = "TestBatchFromNodeSdk.docx";

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null, null,
                File.ReadAllBytes(LocalTestDataFolder + localFile)
            );

            var request1 = new BatchPartRequest(new GetDocumentWithFormatRequest(
                name: remoteFileName,
                format: "docx",
                folder: remoteDataFolder
            ));

            var actual = this.WordsApi.Batch(request1);
            Assert.IsTrue(actual.Length == 1);
            Assert.IsTrue(actual[0] is Stream); // resulted document stream

            using (var fs = File.OpenWrite(@"d:\net_result.docx"))
            {
                (actual[0] as Stream).CopyTo(fs);
            }
        }
    }
}
