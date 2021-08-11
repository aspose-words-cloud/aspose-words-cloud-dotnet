var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetRunsOnlineRequest(requestDocumentStream, "sections/0/paragraphs/0");
wordsApi.GetRunsOnline(request);