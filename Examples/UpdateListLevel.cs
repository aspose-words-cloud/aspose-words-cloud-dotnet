var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestListUpdate = new ListLevelUpdate()
{
    Alignment = ListLevelUpdate.AlignmentEnum.Right
};
var updateRequest = new UpdateListLevelRequest("TestGetLists.doc", 1, 1, requestListUpdate);
wordsApi.UpdateListLevel(updateRequest);