var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteHeadersFootersRequest("Sample.docx", "");
wordsApi.DeleteHeadersFooters(deleteRequest);