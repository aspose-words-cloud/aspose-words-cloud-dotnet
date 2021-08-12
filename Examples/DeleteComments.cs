var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteCommentsRequest("Sample.docx");
wordsApi.DeleteComments(deleteRequest);