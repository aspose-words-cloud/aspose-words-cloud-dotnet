var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetFieldsRequest("Sample.docx");
wordsApi.GetFields(request);