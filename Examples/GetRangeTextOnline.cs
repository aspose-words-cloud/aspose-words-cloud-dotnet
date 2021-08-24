var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var request = new GetRangeTextOnlineRequest(requestDocument, "id0.0.0", rangeEndIdentifier: "id0.0.1");
wordsApi.GetRangeTextOnline(request);