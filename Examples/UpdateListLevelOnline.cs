var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var updateRequest = new UpdateListLevelOnlineRequest(requestDocumentStream, 1, new ListLevelUpdate()
{
    Alignment = ListLevelUpdate.AlignmentEnum.Right
}, 1);
wordsApi.UpdateListLevelOnline(updateRequest);