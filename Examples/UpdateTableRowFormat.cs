var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateTableRowFormatRequest("Sample.docx", "sections/0/tables/2", 0, new TableRowFormat()
{
    AllowBreakAcrossPages = true,
    HeadingFormat = true,
    Height = 10.0f,
    HeightRule = TableRowFormat.HeightRuleEnum.Exactly
});
wordsApi.UpdateTableRowFormat(updateRequest);