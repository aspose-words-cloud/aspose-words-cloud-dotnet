var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateTablePropertiesRequest("Sample.docx", 1, new TableProperties()
{
    Alignment = TableProperties.AlignmentEnum.Right,
    AllowAutoFit = false,
    Bidi = true,
    BottomPadding = 1.0f,
    CellSpacing = 2.0f,
    StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
});
wordsApi.UpdateTableProperties(updateRequest);