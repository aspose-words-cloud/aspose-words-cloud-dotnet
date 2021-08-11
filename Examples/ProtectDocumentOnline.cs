var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var protectRequest = new ProtectDocumentOnlineRequest(requestDocumentStream, new ProtectionRequest()
{
    NewPassword = "123"
});
wordsApi.ProtectDocumentOnline(protectRequest);