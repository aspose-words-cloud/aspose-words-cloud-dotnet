var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var deleteRequest = new DeleteWatermarkRequest(remoteFileName, destFileName: remoteFileName);
wordsApi.DeleteWatermark(deleteRequest);