var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestProtectionRequest = new ProtectionRequest()
{
    Password = "aspose"
};
var unprotectRequest = new UnprotectDocumentRequest("Sample.docx", requestProtectionRequest);
wordsApi.UnprotectDocument(unprotectRequest);