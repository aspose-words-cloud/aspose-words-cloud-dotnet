var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestReplaceText = new ReplaceTextParameters()
{
    OldValue = "Testing",
    NewValue = "Aspose testing"
};
var replaceRequest = new ReplaceTextRequest("Sample.docx", requestReplaceText);
wordsApi.ReplaceText(replaceRequest);