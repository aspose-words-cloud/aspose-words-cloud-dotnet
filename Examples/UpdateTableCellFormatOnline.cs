var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateTableCellFormatOnlineRequest(requestDocumentStream, "sections/0/tables/2/rows/0", new TableCellFormat()
{
    BottomPadding = 5f,
    FitText = true,
    HorizontalMerge = TableCellFormat.HorizontalMergeEnum.First,
    WrapText = true
}, 0);
wordsApi.UpdateTableCellFormatOnline(updateRequest);