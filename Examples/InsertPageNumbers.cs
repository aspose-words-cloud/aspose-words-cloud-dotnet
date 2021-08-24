var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestPageNumber = new PageNumber()
{
    Alignment = "center",
    Format = "{PAGE} of {NUMPAGES}"
};
var insertRequest = new InsertPageNumbersRequest("Sample.docx", requestPageNumber);
wordsApi.InsertPageNumbers(insertRequest);