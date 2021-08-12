var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateTablePropertiesOnlineRequest(requestDocumentStream, new TableProperties()
{
    Alignment = TableProperties.AlignmentEnum.Right,
    AllowAutoFit = false,
    Bidi = true,
    BottomPadding = 1f,
    CellSpacing = 2f,
    StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
}, 1);
wordsApi.UpdateTablePropertiesOnline(updateRequest);