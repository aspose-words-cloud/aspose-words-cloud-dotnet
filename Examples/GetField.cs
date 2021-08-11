var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetFieldRequest("Sample.docx", 0);
wordsApi.GetField(request);