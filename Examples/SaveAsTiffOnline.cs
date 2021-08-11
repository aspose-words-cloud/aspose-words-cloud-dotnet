var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Common/test_multi_pages.docx");
var saveRequest = new SaveAsTiffOnlineRequest(requestDocumentStream, new TiffSaveOptionsData()
{
    SaveFormat = "tiff",
    FileName = "/abc.tiff"
});
wordsApi.SaveAsTiffOnline(saveRequest);