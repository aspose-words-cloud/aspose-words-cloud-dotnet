var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var renderRequest = new RenderParagraphOnlineRequest(requestDocumentStream, "png", 0);
wordsApi.RenderParagraphOnline(renderRequest);