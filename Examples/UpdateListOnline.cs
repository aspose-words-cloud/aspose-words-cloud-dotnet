var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestListUpdate = new ListUpdate()
{
    IsRestartAtEachSection = true
};
var updateRequest = new UpdateListOnlineRequest(requestDocument, 1, requestListUpdate);
wordsApi.UpdateListOnline(updateRequest);