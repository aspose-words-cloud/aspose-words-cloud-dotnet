var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Common/Sample.docx");
var insertRequest = new InsertPageNumbersOnlineRequest(requestDocumentStream, new PageNumber()
{
    Alignment = "center",
    Format = "{PAGE} of {NUMPAGES}"
});
wordsApi.InsertPageNumbersOnline(insertRequest);