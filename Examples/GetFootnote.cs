var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetFootnoteRequest("Sample.docx", 0);
wordsApi.GetFootnote(request);