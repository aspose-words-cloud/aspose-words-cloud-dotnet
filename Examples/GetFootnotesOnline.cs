var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/Footnote.doc");
var request = new GetFootnotesOnlineRequest(requestDocumentStream, nodePath: "");
wordsApi.GetFootnotesOnline(request);