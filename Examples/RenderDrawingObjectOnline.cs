var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var renderRequest = new RenderDrawingObjectOnlineRequest(requestDocument, "png", 0, nodePath: "sections/0");
wordsApi.RenderDrawingObjectOnline(renderRequest);