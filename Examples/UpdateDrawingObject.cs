var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestDrawingObject = new DrawingObjectUpdate()
{
    Left = 0f
};
using var requestImageFile = File.OpenRead("Common/aspose-cloud.png");
var updateRequest = new UpdateDrawingObjectRequest("Sample.docx", requestDrawingObject, requestImageFile, 0);
wordsApi.UpdateDrawingObject(updateRequest);