var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestDrawingObject = new DrawingObjectUpdate()
{
    Left = 0f
};
using var requestImageFile = File.OpenRead("Common/aspose-cloud.png");
var updateRequest = new UpdateDrawingObjectOnlineRequest(requestDocument, requestDrawingObject, requestImageFile, 0);
wordsApi.UpdateDrawingObjectOnline(updateRequest);