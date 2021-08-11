var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/HeaderFooters/HeadersFooters.doc");
var request = new GetHeaderFooterOfSectionOnlineRequest(requestDocumentStream, 0, 0);
wordsApi.GetHeaderFooterOfSectionOnline(request);