var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var optimizeRequest = new OptimizeDocumentOnlineRequest(requestDocumentStream, new OptimizationOptions()
{
    MsWordVersion = OptimizationOptions.MsWordVersionEnum.Word2002
});
wordsApi.OptimizeDocumentOnline(optimizeRequest);