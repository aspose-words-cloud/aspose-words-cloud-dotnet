var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var unprotectRequest = new UnprotectDocumentRequest("Sample.docx", new ProtectionRequest()
{
    Password = "aspose"
});
wordsApi.UnprotectDocument(unprotectRequest);