var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteWatermarkRequest("Sample.docx");
wordsApi.DeleteWatermark(deleteRequest);