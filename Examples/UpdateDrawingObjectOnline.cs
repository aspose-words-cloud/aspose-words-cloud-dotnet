var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
using var requestImageFileStream = File.OpenRead("Common/aspose-cloud.png");
var updateRequest = new UpdateDrawingObjectOnlineRequest(requestDocumentStream, new DrawingObjectUpdate()
{
    Left = 0f
}, requestImageFileStream, 0);
wordsApi.UpdateDrawingObjectOnline(updateRequest);