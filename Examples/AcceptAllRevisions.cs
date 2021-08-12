var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var acceptRequest = new AcceptAllRevisionsRequest("Sample.docx");
wordsApi.AcceptAllRevisions(acceptRequest);