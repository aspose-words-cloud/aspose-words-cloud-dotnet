var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var renderRequest = new RenderTableOnlineRequest(requestDocument, "png", 0);
wordsApi.RenderTableOnline(renderRequest);