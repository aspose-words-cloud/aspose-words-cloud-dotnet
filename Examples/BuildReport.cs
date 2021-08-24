var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestReportEngineSettingsReportBuildOptions = new List<ReportBuildOptions>()
{
    ReportBuildOptions.AllowMissingMembers,
    ReportBuildOptions.RemoveEmptyParagraphs
};
var requestReportEngineSettings = new ReportEngineSettings()
{
    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
    ReportBuildOptions = requestReportEngineSettingsReportBuildOptions
};
var buildReportRequest = new BuildReportRequest("Sample.docx", "Data.json", requestReportEngineSettings);
wordsApi.BuildReport(buildReportRequest);