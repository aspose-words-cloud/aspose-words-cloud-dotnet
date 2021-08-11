var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/Range/RangeGet.doc");
var replaceRequest = new ReplaceWithTextOnlineRequest(requestDocumentStream, "id0.0.0", new ReplaceRange()
{
    Text = "Replaced header"
}, rangeEndIdentifier: "id0.0.1");
wordsApi.ReplaceWithTextOnline(replaceRequest);