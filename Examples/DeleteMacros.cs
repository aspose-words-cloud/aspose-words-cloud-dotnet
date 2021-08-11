var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteMacrosRequest("Sample.docx");
wordsApi.DeleteMacros(deleteRequest);