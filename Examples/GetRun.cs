var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetRunRequest("Sample.docx", "paragraphs/0", 0);
wordsApi.GetRun(request);