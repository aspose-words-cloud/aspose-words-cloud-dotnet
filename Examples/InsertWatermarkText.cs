var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertWatermarkTextRequest("Sample.docx", new WatermarkText()
{
    Text = "This is the text",
    RotationAngle = 90.0f
});
wordsApi.InsertWatermarkText(insertRequest);