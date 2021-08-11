var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteParagraphTabStopRequest("Sample.docx", 72.0f, 0);
wordsApi.DeleteParagraphTabStop(deleteRequest);