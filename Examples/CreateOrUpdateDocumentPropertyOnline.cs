var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestProperty = new DocumentPropertyCreateOrUpdate()
{
    Value = "Imran Anwar"
};
var createRequest = new CreateOrUpdateDocumentPropertyOnlineRequest(requestDocument, "AsposeAuthor", requestProperty);
wordsApi.CreateOrUpdateDocumentPropertyOnline(createRequest);