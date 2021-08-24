var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var request = new GetHeaderFooterOfSectionOnlineRequest(requestDocument, 0, 0);
wordsApi.GetHeaderFooterOfSectionOnline(request);