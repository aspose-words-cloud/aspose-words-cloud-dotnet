var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateRunRequest("Sample.docx", "paragraphs/1", 0, new RunUpdate()
{
    Text = "run with text"
});
wordsApi.UpdateRun(updateRequest);