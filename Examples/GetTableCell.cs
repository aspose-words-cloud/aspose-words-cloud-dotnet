var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetTableCellRequest("Sample.docx", "sections/0/tables/2/rows/0", 0);
wordsApi.GetTableCell(request);