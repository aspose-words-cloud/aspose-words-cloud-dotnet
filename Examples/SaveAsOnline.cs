var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Common/test_multi_pages.docx");
var requestSaveOptionsData = new SaveOptionsData()
{
    SaveFormat = "pdf",
    FileName = "/TestSaveAs.pdf"
};
var saveRequest = new SaveAsOnlineRequest(requestDocument, requestSaveOptionsData);
wordsApi.SaveAsOnline(saveRequest);