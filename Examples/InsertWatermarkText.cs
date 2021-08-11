var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var insertRequest = new InsertWatermarkTextRequest(remoteFileName, new WatermarkText()
{
    Text = "This is the text",
    RotationAngle = 90.0f
}, destFileName: remoteFileName);
wordsApi.InsertWatermarkText(insertRequest);