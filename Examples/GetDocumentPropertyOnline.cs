var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetDocumentPropertyOnlineRequest(requestDocumentStream, "Author");
wordsApi.GetDocumentPropertyOnline(request);