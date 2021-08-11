var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertTableCellOnlineRequest(requestDocumentStream, "sections/0/tables/2/rows/0", new TableCellInsert()
{
});
wordsApi.InsertTableCellOnline(insertRequest);