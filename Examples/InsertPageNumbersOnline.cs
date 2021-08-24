var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Common/Sample.docx");
var requestPageNumber = new PageNumber()
{
    Alignment = "center",
    Format = "{PAGE} of {NUMPAGES}"
};
var insertRequest = new InsertPageNumbersOnlineRequest(requestDocument, requestPageNumber);
wordsApi.InsertPageNumbersOnline(insertRequest);