var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteCommentRequest("Sample.docx", 0);
wordsApi.DeleteComment(deleteRequest);