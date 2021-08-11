var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var buildReportRequest = new BuildReportRequest("Sample.docx", "Data.json", new ReportEngineSettings()
{
    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
    ReportBuildOptions = new List<ReportBuildOptions>()
    {
        ReportBuildOptions.AllowMissingMembers,
        ReportBuildOptions.RemoveEmptyParagraphs
    }
});
wordsApi.BuildReport(buildReportRequest);