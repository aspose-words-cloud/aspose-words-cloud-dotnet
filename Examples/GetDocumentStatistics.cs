var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentStatisticsRequest("Sample.docx");
wordsApi.GetDocumentStatistics(request);