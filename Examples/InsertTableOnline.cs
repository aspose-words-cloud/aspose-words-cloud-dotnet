var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestTable = new TableInsert()
{
    ColumnsCount = 5,
    RowsCount = 4
};
var insertRequest = new InsertTableOnlineRequest(requestDocument, requestTable);
wordsApi.InsertTableOnline(insertRequest);