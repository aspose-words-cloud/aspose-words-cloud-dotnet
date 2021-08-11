var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/Lists/ListsGet.doc");
var request = new GetListsOnlineRequest(requestDocumentStream);
wordsApi.GetListsOnline(request);