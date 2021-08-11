var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteDrawingObjectRequest("Sample.docx", 0);
wordsApi.DeleteDrawingObject(deleteRequest);