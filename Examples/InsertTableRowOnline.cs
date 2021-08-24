var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestRow = new TableRowInsert()
{
    ColumnsCount = 5
};
var insertRequest = new InsertTableRowOnlineRequest(requestDocument, "sections/0/tables/2", requestRow);
wordsApi.InsertTableRowOnline(insertRequest);