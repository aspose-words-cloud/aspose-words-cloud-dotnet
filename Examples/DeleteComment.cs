var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var deleteRequest = new DeleteCommentRequest(remoteFileName, 0, destFileName: remoteFileName);
wordsApi.DeleteComment(deleteRequest);