var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteFormFieldRequest("Sample.docx", 0);
wordsApi.DeleteFormField(deleteRequest);