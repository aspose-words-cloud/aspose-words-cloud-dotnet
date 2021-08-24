var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var renderRequest = new RenderPageOnlineRequest(requestDocument, 1, "bmp");
wordsApi.RenderPageOnline(renderRequest);