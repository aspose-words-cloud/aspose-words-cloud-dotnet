var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var acceptRequest = new AcceptAllRevisionsRequest(remoteFileName, destFileName: remoteFileName);
wordsApi.AcceptAllRevisions(acceptRequest);