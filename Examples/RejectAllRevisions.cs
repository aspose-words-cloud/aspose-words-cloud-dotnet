var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var rejectRequest = new RejectAllRevisionsRequest("Sample.docx");
wordsApi.RejectAllRevisions(rejectRequest);