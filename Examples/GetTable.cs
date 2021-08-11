var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetTableRequest("Sample.docx", 1);
wordsApi.GetTable(request);