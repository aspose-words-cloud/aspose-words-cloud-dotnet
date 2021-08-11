var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetTableRowFormatOnlineRequest(requestDocumentStream, "sections/0/tables/2", 0);
wordsApi.GetTableRowFormatOnline(request);