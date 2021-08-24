var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestProtectionRequest = new ProtectionRequest()
{
    Password = "aspose"
};
var unprotectRequest = new UnprotectDocumentOnlineRequest(requestDocument, requestProtectionRequest);
wordsApi.UnprotectDocumentOnline(unprotectRequest);