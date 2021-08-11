var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetDocumentDrawingObjectByIndexOnlineRequest(requestDocumentStream, 0, nodePath: "sections/0");
wordsApi.GetDocumentDrawingObjectByIndexOnline(request);