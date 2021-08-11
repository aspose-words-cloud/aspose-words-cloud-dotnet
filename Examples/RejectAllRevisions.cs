var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var rejectRequest = new RejectAllRevisionsRequest(remoteFileName, destFileName: remoteFileName);
wordsApi.RejectAllRevisions(rejectRequest);