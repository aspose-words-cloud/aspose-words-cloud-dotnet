var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestRangeText = new ReplaceRange()
{
    Text = "Replaced header"
};
var replaceRequest = new ReplaceWithTextOnlineRequest(requestDocument, "id0.0.0", requestRangeText, rangeEndIdentifier: "id0.0.1");
wordsApi.ReplaceWithTextOnline(replaceRequest);