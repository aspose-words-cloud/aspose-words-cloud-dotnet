var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/ParagraphTabStops.docx");
var request = new GetParagraphTabStopsOnlineRequest(requestDocumentStream, 0, nodePath: "");
wordsApi.GetParagraphTabStopsOnline(request);