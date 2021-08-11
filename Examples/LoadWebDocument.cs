var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var loadRequest = new LoadWebDocumentRequest(new LoadWebDocumentData()
{
    LoadingDocumentUrl = "http://google.com",
    SaveOptions = new SaveOptionsData()
    {
        FileName = "google.doc",
        SaveFormat = "doc",
        DmlEffectsRenderingMode = "1",
        DmlRenderingMode = "1",
        UpdateSdtContent = false,
        ZipOutput = false
    }
});
wordsApi.LoadWebDocument(loadRequest);