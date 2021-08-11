var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateBorderOnlineRequest(requestDocumentStream, new Border()
{
    BorderType = Border.BorderTypeEnum.Left,
    Color = new XmlColor()
    {
        Web = "#AABBCC"
    },
    DistanceFromText = 6f,
    LineStyle = Border.LineStyleEnum.DashDotStroker,
    LineWidth = 2f,
    Shadow = true
}, "left", nodePath: "tables/1/rows/0/cells/0");
wordsApi.UpdateBorderOnline(updateRequest);