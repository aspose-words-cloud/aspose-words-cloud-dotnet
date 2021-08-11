var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var replaceRequest = new ReplaceTextRequest(remoteFileName, new ReplaceTextParameters()
{
    OldValue = "Testing",
    NewValue = "Aspose testing"
}, destFileName: remoteFileName);
wordsApi.ReplaceText(replaceRequest);