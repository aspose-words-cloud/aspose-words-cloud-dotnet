var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetBordersOnlineRequest(requestDocumentStream, nodePath: "tables/1/rows/0/cells/0");
wordsApi.GetBordersOnline(request);