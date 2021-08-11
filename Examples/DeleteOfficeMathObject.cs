var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteOfficeMathObjectRequest("Sample.docx", 0);
wordsApi.DeleteOfficeMathObject(deleteRequest);