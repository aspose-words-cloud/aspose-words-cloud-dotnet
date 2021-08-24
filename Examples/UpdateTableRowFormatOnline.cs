var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestFormat = new TableRowFormat()
{
    AllowBreakAcrossPages = true,
    HeadingFormat = true,
    Height = 10f,
    HeightRule = TableRowFormat.HeightRuleEnum.Auto
};
var updateRequest = new UpdateTableRowFormatOnlineRequest(requestDocument, "sections/0/tables/2", requestFormat, 0);
wordsApi.UpdateTableRowFormatOnline(updateRequest);