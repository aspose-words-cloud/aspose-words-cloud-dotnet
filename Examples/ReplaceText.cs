var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var replaceRequest = new ReplaceTextRequest("Sample.docx", new ReplaceTextParameters()
{
    OldValue = "Testing",
    NewValue = "Aspose testing"
});
wordsApi.ReplaceText(replaceRequest);