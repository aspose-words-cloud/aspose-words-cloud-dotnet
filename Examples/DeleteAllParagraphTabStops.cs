var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteAllParagraphTabStopsRequest("Sample.docx", 0);
wordsApi.DeleteAllParagraphTabStops(deleteRequest);