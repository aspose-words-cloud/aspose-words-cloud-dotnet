var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var request = new GetListOnlineRequest(requestDocumentStream, 1);
wordsApi.GetListOnline(request);