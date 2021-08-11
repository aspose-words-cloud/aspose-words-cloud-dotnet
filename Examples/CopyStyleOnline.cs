var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var copyRequest = new CopyStyleOnlineRequest(requestDocumentStream, new StyleCopy()
{
    StyleName = "Heading 1"
});
wordsApi.CopyStyleOnline(copyRequest);