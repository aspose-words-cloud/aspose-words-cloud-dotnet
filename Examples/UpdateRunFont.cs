var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateRunFontRequest("Sample.docx", "paragraphs/0", 0, new Font()
{
    Bold = true
});
wordsApi.UpdateRunFont(updateRequest);