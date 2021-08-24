var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestProperties = new TableProperties()
{
    Alignment = TableProperties.AlignmentEnum.Right,
    AllowAutoFit = false,
    Bidi = true,
    BottomPadding = 1f,
    CellSpacing = 2f,
    StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
};
var updateRequest = new UpdateTablePropertiesOnlineRequest(requestDocument, requestProperties, 1);
wordsApi.UpdateTablePropertiesOnline(updateRequest);