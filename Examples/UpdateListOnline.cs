var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/Lists/ListsGet.doc");
var updateRequest = new UpdateListOnlineRequest(requestDocumentStream, 1, new ListUpdate()
{
    IsRestartAtEachSection = true
});
wordsApi.UpdateListOnline(updateRequest);