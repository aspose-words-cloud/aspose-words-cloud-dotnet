// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="BuildReportTest.cs">
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

namespace Aspose.Words.Cloud.Sdk.Tests.Report
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;
    using NUnit.Framework;

    /// <summary>
    /// Example of how to perform mail merge
    /// </summary>
    [TestFixture]
    public class BuildReportTest : BaseTestContext
    {
        private readonly string reportFolder = "DocumentActions/Reporting/";

        /// <summary>
        /// Test for build report online.
        /// </summary>
        [Test]
        public void TestBuildReportOnline()
        {
            using (var file = File.OpenRead(BaseTestContext.GetDataDir(this.reportFolder) + "ReportTemplate.docx"))
            {
                var data = File.ReadAllText(BaseTestContext.GetDataDir(this.reportFolder) + "ReportData.json");
                var settings = new ReportEngineSettings
                {
                    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
                    DataSourceName = "persons",
                };
                var request = new BuildReportOnlineRequest(file, data, settings);
                var result = this.WordsApi.BuildReportOnline(request);

                Assert.IsTrue(result.Length > 0, "Error occurred while executing build report online");
            }
        }

        /// <summary>
        /// Test for build report.
        /// </summary>
        [Test]
        public void TestBuildReport()
        {
            var localName = "ReportTemplate.docx";
            var remoteName = "TestBuildReport.docx";
            var fullName = Path.Combine(this.reportFolder, remoteName);
            var data = File.ReadAllText(BaseTestContext.GetDataDir(this.reportFolder) + "ReportData.json");

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.reportFolder) + localName));

            var settings = new ReportEngineSettings
            {
                DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
                ReportBuildOptions = new List<ReportBuildOptions>
                {
                    ReportBuildOptions.AllowMissingMembers,
                    ReportBuildOptions.RemoveEmptyParagraphs,
                }
            };
            var request = new BuildReportRequest(remoteName, data, settings, this.reportFolder);
            this.WordsApi.BuildReport(request);
        }
    }
}