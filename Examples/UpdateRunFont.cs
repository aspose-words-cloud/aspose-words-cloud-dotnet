var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var updateRequest = new UpdateRunFontRequest(remoteFileName, "paragraphs/0", 0, new Font()
{
    Bold = true
}, destFileName: remoteFileName);
wordsApi.UpdateRunFont(updateRequest);