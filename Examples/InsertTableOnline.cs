var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertTableOnlineRequest(requestDocumentStream, new TableInsert()
{
    ColumnsCount = 5,
    RowsCount = 4
});
wordsApi.InsertTableOnline(insertRequest);