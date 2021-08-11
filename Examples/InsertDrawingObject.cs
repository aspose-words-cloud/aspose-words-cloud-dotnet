var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestImageFileStream = File.OpenRead("Common/aspose-cloud.png");
var insertRequest = new InsertDrawingObjectRequest("Sample.docx", new DrawingObjectInsert()
{
    Height = 0f,
    Left = 0f,
    Top = 0f,
    Width = 0f,
    RelativeHorizontalPosition = DrawingObjectInsert.RelativeHorizontalPositionEnum.Margin,
    RelativeVerticalPosition = DrawingObjectInsert.RelativeVerticalPositionEnum.Margin,
    WrapType = DrawingObjectInsert.WrapTypeEnum.Inline
}, requestImageFileStream);
wordsApi.InsertDrawingObject(insertRequest);