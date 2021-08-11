var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetDocumentDrawingObjectImageDataOnlineRequest(requestDocumentStream, 0, nodePath: "sections/0");
wordsApi.GetDocumentDrawingObjectImageDataOnline(request);