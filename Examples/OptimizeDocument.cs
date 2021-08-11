var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var optimizeRequest = new OptimizeDocumentRequest("Sample.docx", new OptimizationOptions()
{
    MsWordVersion = OptimizationOptions.MsWordVersionEnum.Word2002
});
wordsApi.OptimizeDocument(optimizeRequest);