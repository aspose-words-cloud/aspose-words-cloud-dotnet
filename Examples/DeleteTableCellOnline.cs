var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteTableCellOnlineRequest(requestDocumentStream, "sections/0/tables/2/rows/0", 0);
wordsApi.DeleteTableCellOnline(deleteRequest);