var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestWatermarkText = new WatermarkText()
{
    Text = "This is the text",
    RotationAngle = 90f
};
var insertRequest = new InsertWatermarkTextOnlineRequest(requestDocument, requestWatermarkText);
wordsApi.InsertWatermarkTextOnline(insertRequest);