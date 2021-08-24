var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestTemplate = File.OpenRead("Sample.docx");
var requestReportEngineSettings = new ReportEngineSettings()
{
    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
    DataSourceName = "persons"
};
var buildReportRequest = new BuildReportOnlineRequest(requestTemplate, "Data.json", requestReportEngineSettings);
wordsApi.BuildReportOnline(buildReportRequest);