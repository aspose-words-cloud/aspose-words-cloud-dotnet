var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var deleteRequest = new DeleteCommentsRequest(remoteFileName, destFileName: remoteFileName);
wordsApi.DeleteComments(deleteRequest);