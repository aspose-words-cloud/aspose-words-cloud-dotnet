var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var updateRequest = new UpdateRunOnlineRequest(requestDocumentStream, "paragraphs/1", new RunUpdate()
{
    Text = "run with text"
}, 0);
wordsApi.UpdateRunOnline(updateRequest);