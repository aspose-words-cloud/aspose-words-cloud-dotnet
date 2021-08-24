var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetDocumentDrawingObjectImageDataOnlineRequest(requestDocument, 0, nodePath: "sections/0");
wordsApi.GetDocumentDrawingObjectImageDataOnline(request);