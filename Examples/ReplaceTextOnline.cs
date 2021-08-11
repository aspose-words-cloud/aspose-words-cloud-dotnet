var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var replaceRequest = new ReplaceTextOnlineRequest(requestDocumentStream, new ReplaceTextParameters()
{
    OldValue = "aspose",
    NewValue = "aspose new"
});
wordsApi.ReplaceTextOnline(replaceRequest);