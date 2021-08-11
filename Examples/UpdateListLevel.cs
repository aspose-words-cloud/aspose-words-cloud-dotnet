var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateListLevelRequest("TestGetLists.doc", 1, 1, new ListLevelUpdate()
{
    Alignment = ListLevelUpdate.AlignmentEnum.Right
});
wordsApi.UpdateListLevel(updateRequest);