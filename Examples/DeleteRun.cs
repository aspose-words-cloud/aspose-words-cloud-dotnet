var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteRunRequest("Sample.docx", "paragraphs/1", 0);
wordsApi.DeleteRun(deleteRequest);