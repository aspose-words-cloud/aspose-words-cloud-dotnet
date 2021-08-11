var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/Text/SampleWordDocument.docx");
var renderRequest = new RenderPageOnlineRequest(requestDocumentStream, 1, "bmp");
wordsApi.RenderPageOnline(renderRequest);