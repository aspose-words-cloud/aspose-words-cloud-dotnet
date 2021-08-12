var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var deleteRequest = new DeleteHeaderFooterOnlineRequest(requestDocumentStream, "", 0);
wordsApi.DeleteHeaderFooterOnline(deleteRequest);