var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var renderRequest = new RenderDrawingObjectOnlineRequest(requestDocumentStream, "png", 0, nodePath: "sections/0");
wordsApi.RenderDrawingObjectOnline(renderRequest);