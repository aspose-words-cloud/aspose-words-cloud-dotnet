var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetHeaderFootersRequest("Sample.docx", "");
wordsApi.GetHeaderFooters(request);