var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/HeaderFooters/HeadersFooters.doc");
var deleteRequest = new DeleteHeadersFootersOnlineRequest(requestDocumentStream, "");
wordsApi.DeleteHeadersFootersOnline(deleteRequest);