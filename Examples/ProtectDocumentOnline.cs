var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestProtectionRequest = new ProtectionRequest()
{
    NewPassword = "123"
};
var protectRequest = new ProtectDocumentOnlineRequest(requestDocument, requestProtectionRequest);
wordsApi.ProtectDocumentOnline(protectRequest);