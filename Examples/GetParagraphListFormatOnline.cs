var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var request = new GetParagraphListFormatOnlineRequest(requestDocumentStream, 0);
wordsApi.GetParagraphListFormatOnline(request);