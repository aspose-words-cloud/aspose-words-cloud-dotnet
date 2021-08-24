var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestSaveOptions = new TiffSaveOptionsData()
{
    SaveFormat = "tiff",
    FileName = "/abc.tiff"
};
var saveRequest = new SaveAsTiffRequest("Sample.docx", requestSaveOptions);
wordsApi.SaveAsTiff(saveRequest);