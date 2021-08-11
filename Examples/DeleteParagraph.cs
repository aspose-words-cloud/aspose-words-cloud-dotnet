var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteParagraphRequest("Sample.docx", 0);
wordsApi.DeleteParagraph(deleteRequest);