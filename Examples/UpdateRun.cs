var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestRun = new RunUpdate()
{
    Text = "run with text"
};
var updateRequest = new UpdateRunRequest("Sample.docx", "paragraphs/1", 0, requestRun);
wordsApi.UpdateRun(updateRequest);