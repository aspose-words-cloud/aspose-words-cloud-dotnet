var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestPageSetup = new PageSetup()
{
    RtlGutter = true,
    LeftMargin = 10f,
    Orientation = PageSetup.OrientationEnum.Landscape,
    PaperSize = PageSetup.PaperSizeEnum.A5
};
var updateRequest = new UpdateSectionPageSetupOnlineRequest(requestDocument, 0, requestPageSetup);
wordsApi.UpdateSectionPageSetupOnline(updateRequest);