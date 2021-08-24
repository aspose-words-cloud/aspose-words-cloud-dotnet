var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestStyleCopy = new StyleCopy()
{
    StyleName = "Heading 1"
};
var copyRequest = new CopyStyleOnlineRequest(requestDocument, requestStyleCopy);
wordsApi.CopyStyleOnline(copyRequest);