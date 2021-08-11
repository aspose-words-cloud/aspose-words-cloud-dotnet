var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/ParagraphGetListFormat.doc");
var request = new GetParagraphListFormatOnlineRequest(requestDocumentStream, 0, nodePath: "");
wordsApi.GetParagraphListFormatOnline(request);