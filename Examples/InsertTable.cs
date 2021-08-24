var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestTable = new TableInsert()
{
    ColumnsCount = 5,
    RowsCount = 4
};
var insertRequest = new InsertTableRequest("Sample.docx", requestTable);
wordsApi.InsertTable(insertRequest);