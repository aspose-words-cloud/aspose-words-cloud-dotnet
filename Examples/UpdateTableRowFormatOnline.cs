var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateTableRowFormatOnlineRequest(requestDocumentStream, "sections/0/tables/2", new TableRowFormat()
{
    AllowBreakAcrossPages = true,
    HeadingFormat = true,
    Height = 10f,
    HeightRule = TableRowFormat.HeightRuleEnum.Auto
}, 0);
wordsApi.UpdateTableRowFormatOnline(updateRequest);