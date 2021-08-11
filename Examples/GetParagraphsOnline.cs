var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetParagraphsOnlineRequest(requestDocumentStream, nodePath: "sections/0");
wordsApi.GetParagraphsOnline(request);