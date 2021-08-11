var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentHyperlinksRequest("Sample.docx");
wordsApi.GetDocumentHyperlinks(request);