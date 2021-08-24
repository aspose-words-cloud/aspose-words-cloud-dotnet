var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestDrawingObject = new DrawingObjectInsert()
{
    Height = 0f,
    Left = 0f,
    Top = 0f,
    Width = 0f,
    RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
    RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
    WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
};
using var requestImageFile = File.OpenRead("Common/aspose-cloud.png");
var insertRequest = new InsertDrawingObjectOnlineRequest(requestDocument, requestDrawingObject, requestImageFile);
wordsApi.InsertDrawingObjectOnline(insertRequest);