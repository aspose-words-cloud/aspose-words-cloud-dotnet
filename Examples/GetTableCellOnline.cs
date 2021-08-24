var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetTableCellOnlineRequest(requestDocument, "sections/0/tables/2/rows/0", 0);
wordsApi.GetTableCellOnline(request);