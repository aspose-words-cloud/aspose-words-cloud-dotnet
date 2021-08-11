var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateTableCellFormatRequest("Sample.docx", "sections/0/tables/2/rows/0", 0, new TableCellFormat()
{
    BottomPadding = 5.0f,
    FitText = true,
    HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First,
    WrapText = true
});
wordsApi.UpdateTableCellFormat(updateRequest);