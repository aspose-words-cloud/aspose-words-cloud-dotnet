var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteFootnoteRequest("Sample.docx", 0);
wordsApi.DeleteFootnote(deleteRequest);