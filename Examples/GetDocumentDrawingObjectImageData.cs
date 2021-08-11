var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentDrawingObjectImageDataRequest("Sample.docx", 0);
wordsApi.GetDocumentDrawingObjectImageData(request);