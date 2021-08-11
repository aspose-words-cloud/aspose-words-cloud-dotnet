var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteTableRequest("Sample.docx", 1);
wordsApi.DeleteTable(deleteRequest);