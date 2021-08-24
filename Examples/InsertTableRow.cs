var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestRow = new TableRowInsert()
{
    ColumnsCount = 5
};
var insertRequest = new InsertTableRowRequest("Sample.docx", "sections/0/tables/2", requestRow);
wordsApi.InsertTableRow(insertRequest);