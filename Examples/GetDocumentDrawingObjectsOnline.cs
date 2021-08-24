var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetDocumentDrawingObjectsOnlineRequest(requestDocument, nodePath: "sections/0");
wordsApi.GetDocumentDrawingObjectsOnline(request);