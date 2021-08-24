var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestDataSaveOptions = new SaveOptionsData()
{
    FileName = "google.doc",
    SaveFormat = "doc",
    DmlEffectsRenderingMode = "1",
    DmlRenderingMode = "1",
    UpdateSdtContent = false,
    ZipOutput = false
};
var requestData = new LoadWebDocumentData()
{
    LoadingDocumentUrl = "http://google.com",
    SaveOptions = requestDataSaveOptions
};
var loadRequest = new LoadWebDocumentRequest(requestData);
wordsApi.LoadWebDocument(loadRequest);