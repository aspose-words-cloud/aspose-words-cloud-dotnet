var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetTablesRequest("Sample.docx");
wordsApi.GetTables(request);