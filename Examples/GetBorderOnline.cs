var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetBorderOnlineRequest(requestDocument, "left", nodePath: "tables/1/rows/0/cells/0");
wordsApi.GetBorderOnline(request);