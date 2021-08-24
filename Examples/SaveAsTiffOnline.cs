var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Common/test_multi_pages.docx");
var requestSaveOptions = new TiffSaveOptionsData()
{
    SaveFormat = "tiff",
    FileName = "/abc.tiff"
};
var saveRequest = new SaveAsTiffOnlineRequest(requestDocument, requestSaveOptions);
wordsApi.SaveAsTiffOnline(saveRequest);