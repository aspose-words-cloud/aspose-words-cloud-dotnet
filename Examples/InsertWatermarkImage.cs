var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertWatermarkImageRequest("Sample.docx", imageFile: null, image: "Sample.png");
wordsApi.InsertWatermarkImage(insertRequest);