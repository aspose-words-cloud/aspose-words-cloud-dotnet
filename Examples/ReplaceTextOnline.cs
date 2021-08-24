var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestReplaceText = new ReplaceTextParameters()
{
    OldValue = "aspose",
    NewValue = "aspose new"
};
var replaceRequest = new ReplaceTextOnlineRequest(requestDocument, requestReplaceText);
wordsApi.ReplaceTextOnline(replaceRequest);