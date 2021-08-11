var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertTableRowRequest("Sample.docx", "sections/0/tables/2", new TableRowInsert()
{
    ColumnsCount = 5
});
wordsApi.InsertTableRow(insertRequest);