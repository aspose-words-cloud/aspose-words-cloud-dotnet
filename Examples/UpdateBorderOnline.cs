var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestBorderPropertiesColor = new XmlColor()
{
    Web = "#AABBCC"
};
var requestBorderProperties = new Border()
{
    BorderType = Border.BorderTypeEnum.Left,
    Color = requestBorderPropertiesColor,
    DistanceFromText = 6f,
    LineStyle = Border.LineStyleEnum.DashDotStroker,
    LineWidth = 2f,
    Shadow = true
};
var updateRequest = new UpdateBorderOnlineRequest(requestDocument, requestBorderProperties, "left", nodePath: "tables/1/rows/0/cells/0");
wordsApi.UpdateBorderOnline(updateRequest);