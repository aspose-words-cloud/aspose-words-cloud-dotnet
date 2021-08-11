var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentHyperlinkByIndexRequest("Sample.docx", 0);
wordsApi.GetDocumentHyperlinkByIndex(request);