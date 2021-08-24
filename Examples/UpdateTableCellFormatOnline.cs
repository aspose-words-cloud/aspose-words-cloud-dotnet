var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestFormat = new TableCellFormat()
{
    BottomPadding = 5f,
    FitText = true,
    HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First,
    WrapText = true
};
var updateRequest = new UpdateTableCellFormatOnlineRequest(requestDocument, "sections/0/tables/2/rows/0", requestFormat, 0);
wordsApi.UpdateTableCellFormatOnline(updateRequest);