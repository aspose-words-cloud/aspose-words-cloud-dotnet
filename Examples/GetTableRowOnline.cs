var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetTableRowOnlineRequest(requestDocument, "tables/1", 0);
wordsApi.GetTableRowOnline(request);