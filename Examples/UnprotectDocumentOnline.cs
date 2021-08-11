var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var unprotectRequest = new UnprotectDocumentOnlineRequest(requestDocumentStream, new ProtectionRequest()
{
    Password = "aspose"
});
wordsApi.UnprotectDocumentOnline(unprotectRequest);