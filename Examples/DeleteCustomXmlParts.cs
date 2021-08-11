var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var deleteRequest = new DeleteCustomXmlPartsRequest(remoteFileName, destFileName: remoteFileName);
wordsApi.DeleteCustomXmlParts(deleteRequest);