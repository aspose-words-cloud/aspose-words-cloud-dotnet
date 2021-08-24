var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestListUpdate = new ListUpdate()
{
    IsRestartAtEachSection = true
};
var updateRequest = new UpdateListRequest("TestGetLists.doc", 1, requestListUpdate);
wordsApi.UpdateList(updateRequest);