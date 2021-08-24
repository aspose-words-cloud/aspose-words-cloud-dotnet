var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestWatermarkText = new WatermarkText()
{
    Text = "This is the text",
    RotationAngle = 90.0f
};
var insertRequest = new InsertWatermarkTextRequest("Sample.docx", requestWatermarkText);
wordsApi.InsertWatermarkText(insertRequest);