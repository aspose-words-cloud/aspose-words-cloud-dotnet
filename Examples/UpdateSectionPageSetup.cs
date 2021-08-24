var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestPageSetup = new PageSetup()
{
    RtlGutter = true,
    LeftMargin = 10.0f,
    Orientation = PageSetup.OrientationEnum.Landscape,
    PaperSize = PageSetup.PaperSizeEnum.A5
};
var updateRequest = new UpdateSectionPageSetupRequest("Sample.docx", 0, requestPageSetup);
wordsApi.UpdateSectionPageSetup(updateRequest);