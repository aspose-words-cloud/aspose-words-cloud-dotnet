var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetBorderOnlineRequest(requestDocumentStream, "left", nodePath: "tables/1/rows/0/cells/0");
wordsApi.GetBorderOnline(request);