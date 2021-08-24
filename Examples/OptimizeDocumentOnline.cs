var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestOptions = new OptimizationOptions()
{
    MsWordVersion = OptimizationOptions.MsWordVersionEnum.Word2002
};
var optimizeRequest = new OptimizeDocumentOnlineRequest(requestDocument, requestOptions);
wordsApi.OptimizeDocumentOnline(optimizeRequest);