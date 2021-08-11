var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var saveRequest = new SaveAsRequest("Sample.docx", new SaveOptionsData()
{
    SaveFormat = "docx",
    FileName = "/TestSaveAsFromPdfToDoc.docx"
});
wordsApi.SaveAs(saveRequest);