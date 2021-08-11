var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestTemplateStream = File.OpenRead("Sample.docx");
var buildReportRequest = new BuildReportOnlineRequest(requestTemplateStream, "Data.json", new ReportEngineSettings()
{
    DataSourceType = ReportEngineSettings.DataSourceTypeEnum.Json,
    DataSourceName = "persons"
});
wordsApi.BuildReportOnline(buildReportRequest);