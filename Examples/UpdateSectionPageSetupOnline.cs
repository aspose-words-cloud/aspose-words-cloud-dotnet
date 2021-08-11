var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateSectionPageSetupOnlineRequest(requestDocumentStream, 0, new PageSetup()
{
    RtlGutter = true,
    LeftMargin = 10f,
    Orientation = PageSetup.OrientationEnum.Landscape,
    PaperSize = PageSetup.PaperSizeEnum.A5
});
wordsApi.UpdateSectionPageSetupOnline(updateRequest);