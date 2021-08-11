var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteParagraphListFormatRequest("Sample.docx", 0);
wordsApi.DeleteParagraphListFormat(deleteRequest);