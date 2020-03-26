using System.Collections.Generic;
using System.IO;
using Aspose.Words.Cloud.Sdk.Model;
using Aspose.Words.Cloud.Sdk.Model.Requests;
using Aspose.Words.Cloud.Sdk.Tests.Base;
using NUnit.Framework;

namespace Aspose.Words.Cloud.Sdk.Tests.Report
{
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
                var request = new BuildReportOnlineRequest(file, data,
                    new ReportEngineSettings {DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json});
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
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var data = File.ReadAllText(BaseTestContext.GetDataDir(this.reportFolder) + "ReportData.json");

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.reportFolder) + localName));

            var request = new BuildReportRequest(remoteName, data,
                new ReportEngineSettings
                {
                    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
                    ReportBuildOptions = new List<ReportBuildOptions>
                        {ReportBuildOptions.AllowMissingMembers, ReportBuildOptions.RemoveEmptyParagraphs}
                });
            this.WordsApi.BuildReport(request);
        }
    }
}