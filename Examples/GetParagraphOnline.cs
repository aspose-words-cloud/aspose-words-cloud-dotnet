var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetParagraphOnlineRequest(requestDocument, 0, nodePath: "sections/0");
wordsApi.GetParagraphOnline(request);