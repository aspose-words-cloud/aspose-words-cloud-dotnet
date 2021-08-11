var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetBordersRequest("Sample.docx", nodePath: "tables/1/rows/0/cells/0");
wordsApi.GetBorders(request);