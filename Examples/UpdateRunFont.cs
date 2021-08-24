var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestFontDto = new Font()
{
    Bold = true
};
var updateRequest = new UpdateRunFontRequest("Sample.docx", "paragraphs/0", 0, requestFontDto);
wordsApi.UpdateRunFont(updateRequest);