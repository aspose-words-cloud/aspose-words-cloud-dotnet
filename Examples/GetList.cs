var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetListRequest("TestGetLists.doc", 1);
wordsApi.GetList(request);