// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BuildReportTests.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Tests.Api.Report
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to perform mail merge.
    /// </summary>
    [TestFixture]
    public class BuildReportTests : BaseTestContext
    {
        private readonly string remoteDataFolder = RemoteBaseTestDataFolder + "/DocumentActions/Reporting";
        private readonly string reportingFolder = "DocumentActions/Reporting";

        /// <summary>
        /// Test for build report online.
        /// </summary>
        [Test]
        public void TestBuildReportOnline()
        {
            string localDocumentFile = "ReportTemplate.docx";
            string localDataFile = File.ReadAllText(LocalTestDataFolder + reportingFolder + "/ReportData.json");

            var request = new BuildReportOnlineRequest(
                template: File.OpenRead(LocalTestDataFolder + reportingFolder + "/" + localDocumentFile),
                data: localDataFile,
                reportEngineSettings: new ReportEngineSettings()
                {
                    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
                    DataSourceName = "persons"
                }
            );

            var actual = this.WordsApi.BuildReportOnline(request);
        }

        /// <summary>
        /// Test for build report.
        /// </summary>
        [Test]
        public void TestBuildReport()
        {
            string localDocumentFile = "ReportTemplate.docx";
            string remoteFileName = "TestBuildReport.docx";
            string localDataFile = File.ReadAllText(LocalTestDataFolder + reportingFolder + "/ReportData.json");

            this.UploadFileToStorage(
                remoteDataFolder + "/" + remoteFileName,
                null,
                null,
                File.ReadAllBytes(LocalTestDataFolder + reportingFolder + "/" + localDocumentFile)
            );

            var request = new BuildReportRequest(
                name: remoteFileName,
                data: localDataFile,
                reportEngineSettings: new ReportEngineSettings()
                {
                    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
                    ReportBuildOptions = new List<ReportBuildOptions>()
                    {
                        ReportBuildOptions.AllowMissingMembers,
                        ReportBuildOptions.RemoveEmptyParagraphs
                    }
                },
                folder: remoteDataFolder
            );

            var actual = this.WordsApi.BuildReport(request);
            Assert.NotNull(actual.Document);
            Assert.AreEqual("TestBuildReport.docx", actual.Document.FileName);
        }
    }
}
