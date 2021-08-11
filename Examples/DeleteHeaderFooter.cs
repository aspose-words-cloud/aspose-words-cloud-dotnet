var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteHeaderFooterRequest("Sample.docx", "", 0);
wordsApi.DeleteHeaderFooter(deleteRequest);