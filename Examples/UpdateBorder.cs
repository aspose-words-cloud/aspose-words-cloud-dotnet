var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateBorderRequest("Sample.docx", "left", new Border()
{
    BorderType = Border.BorderTypeEnum.Left,
    Color = new XmlColor()
    {
        Web = "#AABBCC"
    },
    DistanceFromText = 6.0f,
    LineStyle = Border.LineStyleEnum.DashDotStroker,
    LineWidth = 2.0f,
    Shadow = true
}, nodePath: "tables/1/rows/0/cells/0");
wordsApi.UpdateBorder(updateRequest);