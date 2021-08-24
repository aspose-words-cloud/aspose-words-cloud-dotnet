var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestSaveOptionsData = new SaveOptionsData()
{
    SaveFormat = "docx",
    FileName = "/TestSaveAsFromPdfToDoc.docx"
};
var saveRequest = new SaveAsRequest("Sample.docx", requestSaveOptionsData);
wordsApi.SaveAs(saveRequest);