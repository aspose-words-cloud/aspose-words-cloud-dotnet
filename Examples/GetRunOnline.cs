var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetRunOnlineRequest(requestDocumentStream, "paragraphs/0", 0);
wordsApi.GetRunOnline(request);