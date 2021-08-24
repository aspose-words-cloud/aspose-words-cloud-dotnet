var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestRun = new RunUpdate()
{
    Text = "run with text"
};
var updateRequest = new UpdateRunOnlineRequest(requestDocument, "paragraphs/1", requestRun, 0);
wordsApi.UpdateRunOnline(updateRequest);