var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteFieldsRequest("Sample.docx");
wordsApi.DeleteFields(deleteRequest);