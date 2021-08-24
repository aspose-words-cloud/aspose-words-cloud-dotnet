var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var request = new GetListOnlineRequest(requestDocument, 1);
wordsApi.GetListOnline(request);