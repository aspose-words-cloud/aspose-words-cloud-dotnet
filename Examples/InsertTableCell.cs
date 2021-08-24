var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestCell = new TableCellInsert()
{
};
var insertRequest = new InsertTableCellRequest("Sample.docx", "sections/0/tables/2/rows/0", requestCell);
wordsApi.InsertTableCell(insertRequest);