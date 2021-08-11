var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetTableRowFormatRequest("Sample.docx", "sections/0/tables/2", 0);
wordsApi.GetTableRowFormat(request);