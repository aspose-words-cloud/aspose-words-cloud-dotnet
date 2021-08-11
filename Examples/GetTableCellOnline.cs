var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetTableCellOnlineRequest(requestDocumentStream, "sections/0/tables/2/rows/0", 0);
wordsApi.GetTableCellOnline(request);