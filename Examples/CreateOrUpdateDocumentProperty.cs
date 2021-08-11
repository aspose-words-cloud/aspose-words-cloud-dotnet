var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var createRequest = new CreateOrUpdateDocumentPropertyRequest(remoteFileName, "AsposeAuthor", new DocumentPropertyCreateOrUpdate()
{
    Value = "Imran Anwar"
}, destFileName: remoteFileName);
wordsApi.CreateOrUpdateDocumentProperty(createRequest);