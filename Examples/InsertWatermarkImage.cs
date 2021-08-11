var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var insertRequest = new InsertWatermarkImageRequest(remoteFileName, imageFile: null, destFileName: remoteFileName, image: "Sample.png");
wordsApi.InsertWatermarkImage(insertRequest);