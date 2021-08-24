var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestFormat = new TableRowFormat()
{
    AllowBreakAcrossPages = true,
    HeadingFormat = true,
    Height = 10.0f,
    HeightRule = TableRowFormat.HeightRuleEnum.Exactly
};
var updateRequest = new UpdateTableRowFormatRequest("Sample.docx", "sections/0/tables/2", 0, requestFormat);
wordsApi.UpdateTableRowFormat(updateRequest);