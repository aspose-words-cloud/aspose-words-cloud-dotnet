var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var protectRequest = new ProtectDocumentRequest(remoteFileName, new ProtectionRequest()
{
    Password = "123",
    ProtectionType = "ReadOnly"
}, destFileName: remoteFileName);
wordsApi.ProtectDocument(protectRequest);