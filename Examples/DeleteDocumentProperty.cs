var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var deleteRequest = new DeleteDocumentPropertyRequest(remoteFileName, "testProp", destFileName: remoteFileName);
wordsApi.DeleteDocumentProperty(deleteRequest);