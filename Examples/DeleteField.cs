var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteFieldRequest("Sample.docx", 0);
wordsApi.DeleteField(deleteRequest);