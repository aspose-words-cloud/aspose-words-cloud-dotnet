var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentProtectionRequest("Sample.docx");
wordsApi.GetDocumentProtection(request);