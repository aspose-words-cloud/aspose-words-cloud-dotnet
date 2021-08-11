var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/Range/RangeGet.doc");
var removeRequest = new RemoveRangeOnlineRequest(requestDocumentStream, "id0.0.0", rangeEndIdentifier: "id0.0.1");
wordsApi.RemoveRangeOnline(removeRequest);