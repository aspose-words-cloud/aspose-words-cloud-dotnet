var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentDrawingObjectOleDataRequest("Sample.docx", 0);
wordsApi.GetDocumentDrawingObjectOleData(request);