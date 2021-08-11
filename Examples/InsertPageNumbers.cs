var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var insertRequest = new InsertPageNumbersRequest(remoteFileName, new PageNumber()
{
    Alignment = "center",
    Format = "{PAGE} of {NUMPAGES}"
}, destFileName: remoteFileName);
wordsApi.InsertPageNumbers(insertRequest);