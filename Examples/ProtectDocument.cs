var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var protectRequest = new ProtectDocumentRequest("Sample.docx", new ProtectionRequest()
{
    Password = "123",
    ProtectionType = "ReadOnly"
});
wordsApi.ProtectDocument(protectRequest);