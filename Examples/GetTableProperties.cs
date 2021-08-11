var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetTablePropertiesRequest("Sample.docx", 1);
wordsApi.GetTableProperties(request);