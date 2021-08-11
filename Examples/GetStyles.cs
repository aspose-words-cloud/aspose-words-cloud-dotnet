var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetStylesRequest("Sample.docx");
wordsApi.GetStyles(request);