var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var createRequest = new CreateOrUpdateDocumentPropertyRequest("Sample.docx", "AsposeAuthor", new DocumentPropertyCreateOrUpdate()
{
    Value = "Imran Anwar"
});
wordsApi.CreateOrUpdateDocumentProperty(createRequest);