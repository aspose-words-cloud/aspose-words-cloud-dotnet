var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteTableRowRequest("Sample.docx", "tables/1", 0);
wordsApi.DeleteTableRow(deleteRequest);