var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetTableRowRequest("Sample.docx", "tables/1", 0);
wordsApi.GetTableRow(request);