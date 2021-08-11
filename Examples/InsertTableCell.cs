var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertTableCellRequest("Sample.docx", "sections/0/tables/2/rows/0", new TableCellInsert()
{
});
wordsApi.InsertTableCell(insertRequest);