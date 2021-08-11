var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateListRequest("TestGetLists.doc", 1, new ListUpdate()
{
    IsRestartAtEachSection = true
});
wordsApi.UpdateList(updateRequest);