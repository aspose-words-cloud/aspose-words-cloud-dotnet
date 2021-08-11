var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetHeaderFooterOfSectionRequest("Sample.docx", 0, 0);
wordsApi.GetHeaderFooterOfSection(request);