var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestProperty = new DocumentPropertyCreateOrUpdate()
{
    Value = "Imran Anwar"
};
var createRequest = new CreateOrUpdateDocumentPropertyRequest("Sample.docx", "AsposeAuthor", requestProperty);
wordsApi.CreateOrUpdateDocumentProperty(createRequest);