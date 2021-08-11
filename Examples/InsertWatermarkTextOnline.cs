var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertWatermarkTextOnlineRequest(requestDocumentStream, new WatermarkText()
{
    Text = "This is the text",
    RotationAngle = 90f
});
wordsApi.InsertWatermarkTextOnline(insertRequest);