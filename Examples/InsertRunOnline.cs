var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestRun = new RunInsert()
{
    Text = "run with text"
};
var insertRequest = new InsertRunOnlineRequest(requestDocument, "paragraphs/1", requestRun);
wordsApi.InsertRunOnline(insertRequest);