var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var request = new GetParagraphListFormatOnlineRequest(requestDocument, 0);
wordsApi.GetParagraphListFormatOnline(request);