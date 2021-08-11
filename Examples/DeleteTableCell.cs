var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteTableCellRequest("Sample.docx", "sections/0/tables/2/rows/0", 0);
wordsApi.DeleteTableCell(deleteRequest);