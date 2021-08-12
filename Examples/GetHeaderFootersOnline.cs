var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var request = new GetHeaderFootersOnlineRequest(requestDocumentStream, "");
wordsApi.GetHeaderFootersOnline(request);