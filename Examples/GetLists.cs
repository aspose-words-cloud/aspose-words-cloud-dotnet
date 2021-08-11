var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetListsRequest("TestGetLists.doc");
wordsApi.GetLists(request);