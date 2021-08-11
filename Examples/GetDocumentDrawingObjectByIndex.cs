var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentDrawingObjectByIndexRequest("Sample.docx", 0);
wordsApi.GetDocumentDrawingObjectByIndex(request);