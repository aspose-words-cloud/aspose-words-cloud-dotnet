var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestProtectionRequest = new ProtectionRequest()
{
    Password = "123",
    ProtectionType = "ReadOnly"
};
var protectRequest = new ProtectDocumentRequest("Sample.docx", requestProtectionRequest);
wordsApi.ProtectDocument(protectRequest);