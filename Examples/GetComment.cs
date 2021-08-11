var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetCommentRequest("Sample.docx", 0);
wordsApi.GetComment(request);