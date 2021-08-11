var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/HeaderFooters/HeadersFooters.doc");
var request = new GetHeaderFooterOnlineRequest(requestDocumentStream, 0);
wordsApi.GetHeaderFooterOnline(request);