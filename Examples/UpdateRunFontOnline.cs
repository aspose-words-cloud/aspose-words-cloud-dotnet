var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestFontDto = new Font()
{
    Bold = true
};
var updateRequest = new UpdateRunFontOnlineRequest(requestDocument, "paragraphs/0", requestFontDto, 0);
wordsApi.UpdateRunFontOnline(updateRequest);