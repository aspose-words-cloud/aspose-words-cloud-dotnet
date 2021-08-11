var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetHeaderFooterRequest("Sample.docx", 0);
wordsApi.GetHeaderFooter(request);