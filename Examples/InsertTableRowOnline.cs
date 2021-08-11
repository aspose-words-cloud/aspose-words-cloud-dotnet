var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertTableRowOnlineRequest(requestDocumentStream, "sections/0/tables/2", new TableRowInsert()
{
    ColumnsCount = 5
});
wordsApi.InsertTableRowOnline(insertRequest);