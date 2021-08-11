var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateRunFontOnlineRequest(requestDocumentStream, "paragraphs/0", new Font()
{
    Bold = true
}, 0);
wordsApi.UpdateRunFontOnline(updateRequest);