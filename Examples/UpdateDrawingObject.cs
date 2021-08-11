var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestImageFileStream = File.OpenRead("Common/aspose-cloud.png");
var updateRequest = new UpdateDrawingObjectRequest("Sample.docx", new DrawingObjectUpdate()
{
    Left = 0f
}, requestImageFileStream, 0);
wordsApi.UpdateDrawingObject(updateRequest);