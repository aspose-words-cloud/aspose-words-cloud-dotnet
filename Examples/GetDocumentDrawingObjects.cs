var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentDrawingObjectsRequest("Sample.docx");
wordsApi.GetDocumentDrawingObjects(request);