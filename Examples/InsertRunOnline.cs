var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/Runs/Run.doc");
var insertRequest = new InsertRunOnlineRequest(requestDocumentStream, "paragraphs/1", new RunInsert()
{
    Text = "run with text"
});
wordsApi.InsertRunOnline(insertRequest);