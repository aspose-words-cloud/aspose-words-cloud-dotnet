var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestRangeText = new ReplaceRange()
{
    Text = "Replaced header"
};
var replaceRequest = new ReplaceWithTextRequest("Sample.docx", "id0.0.0", requestRangeText, rangeEndIdentifier: "id0.0.1");
wordsApi.ReplaceWithText(replaceRequest);