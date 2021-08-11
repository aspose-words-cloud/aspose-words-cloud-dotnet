var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteTableRowOnlineRequest(requestDocumentStream, "tables/1", 0);
wordsApi.DeleteTableRowOnline(deleteRequest);