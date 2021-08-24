var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestListUpdate = new ListLevelUpdate()
{
    Alignment = ListLevelUpdate.AlignmentEnum.Right
};
var updateRequest = new UpdateListLevelOnlineRequest(requestDocument, 1, requestListUpdate, 1);
wordsApi.UpdateListLevelOnline(updateRequest);