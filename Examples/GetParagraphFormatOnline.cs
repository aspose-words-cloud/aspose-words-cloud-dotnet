var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetParagraphFormatOnlineRequest(requestDocument, 0);
wordsApi.GetParagraphFormatOnline(request);