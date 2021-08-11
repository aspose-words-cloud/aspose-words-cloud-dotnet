var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var saveRequest = new SaveAsTiffRequest("Sample.docx", new TiffSaveOptionsData()
{
    SaveFormat = "tiff",
    FileName = "/abc.tiff"
});
wordsApi.SaveAsTiff(saveRequest);