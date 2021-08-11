var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetTableRowOnlineRequest(requestDocumentStream, "tables/1", 0);
wordsApi.GetTableRowOnline(request);