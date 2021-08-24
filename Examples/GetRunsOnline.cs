var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetRunsOnlineRequest(requestDocument, "sections/0/paragraphs/0");
wordsApi.GetRunsOnline(request);