var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetRunFontOnlineRequest(requestDocument, "paragraphs/0", 0);
wordsApi.GetRunFontOnline(request);