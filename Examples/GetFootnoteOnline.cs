var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var request = new GetFootnoteOnlineRequest(requestDocumentStream, 0);
wordsApi.GetFootnoteOnline(request);