var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertTableRequest("Sample.docx", new TableInsert()
{
    ColumnsCount = 5,
    RowsCount = 4
});
wordsApi.InsertTable(insertRequest);