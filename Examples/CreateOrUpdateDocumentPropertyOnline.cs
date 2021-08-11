var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var createRequest = new CreateOrUpdateDocumentPropertyOnlineRequest(requestDocumentStream, "AsposeAuthor", new DocumentPropertyCreateOrUpdate()
{
    Value = "Imran Anwar"
});
wordsApi.CreateOrUpdateDocumentPropertyOnline(createRequest);