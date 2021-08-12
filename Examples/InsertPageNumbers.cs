var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertPageNumbersRequest("Sample.docx", new PageNumber()
{
    Alignment = "center",
    Format = "{PAGE} of {NUMPAGES}"
});
wordsApi.InsertPageNumbers(insertRequest);