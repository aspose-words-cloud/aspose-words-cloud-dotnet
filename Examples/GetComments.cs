var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetCommentsRequest("Sample.docx");
wordsApi.GetComments(request);