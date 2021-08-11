var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/HeaderFooters/HeadersFooters.doc");
var deleteRequest = new DeleteHeaderFooterOnlineRequest(requestDocumentStream, "", 0);
wordsApi.DeleteHeaderFooterOnline(deleteRequest);