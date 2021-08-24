var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestProperties = new TableProperties()
{
    Alignment = TableProperties.AlignmentEnum.Right,
    AllowAutoFit = false,
    Bidi = true,
    BottomPadding = 1.0f,
    CellSpacing = 2.0f,
    StyleOptions = TableProperties.StyleOptionsEnum.ColumnBands
};
var updateRequest = new UpdateTablePropertiesRequest("Sample.docx", 1, requestProperties);
wordsApi.UpdateTableProperties(updateRequest);