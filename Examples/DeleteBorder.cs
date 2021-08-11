var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteBorderRequest("Sample.docx", "left", nodePath: "tables/1/rows/0/cells/0");
wordsApi.DeleteBorder(deleteRequest);