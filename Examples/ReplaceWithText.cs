var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var replaceRequest = new ReplaceWithTextRequest("Sample.docx", "id0.0.0", new ReplaceRange()
{
    Text = "Replaced header"
}, rangeEndIdentifier: "id0.0.1");
wordsApi.ReplaceWithText(replaceRequest);