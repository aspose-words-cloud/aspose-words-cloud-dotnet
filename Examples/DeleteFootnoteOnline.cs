var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/Footnote.doc");
var deleteRequest = new DeleteFootnoteOnlineRequest(requestDocumentStream, 0, nodePath: "");
wordsApi.DeleteFootnoteOnline(deleteRequest);