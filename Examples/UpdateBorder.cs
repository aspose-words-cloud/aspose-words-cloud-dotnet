var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestBorderPropertiesColor = new XmlColor()
{
    Web = "#AABBCC"
};
var requestBorderProperties = new Border()
{
    BorderType = Border.BorderTypeEnum.Left,
    Color = requestBorderPropertiesColor,
    DistanceFromText = 6.0f,
    LineStyle = Border.LineStyleEnum.DashDotStroker,
    LineWidth = 2.0f,
    Shadow = true
};
var updateRequest = new UpdateBorderRequest("Sample.docx", "left", requestBorderProperties, nodePath: "tables/1/rows/0/cells/0");
wordsApi.UpdateBorder(updateRequest);