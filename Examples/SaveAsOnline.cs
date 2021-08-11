var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Common/test_multi_pages.docx");
var saveRequest = new SaveAsOnlineRequest(requestDocumentStream, new SaveOptionsData()
{
    SaveFormat = "pdf",
    FileName = "/TestSaveAs.pdf"
});
wordsApi.SaveAsOnline(saveRequest);