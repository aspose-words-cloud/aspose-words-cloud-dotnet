var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentRequest("Sample.docx");
wordsApi.GetDocument(request);