var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestOptions = new OptimizationOptions()
{
    MsWordVersion = OptimizationOptions.MsWordVersionEnum.Word2002
};
var optimizeRequest = new OptimizeDocumentRequest("Sample.docx", requestOptions);
wordsApi.OptimizeDocument(optimizeRequest);