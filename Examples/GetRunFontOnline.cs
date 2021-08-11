var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetRunFontOnlineRequest(requestDocumentStream, "paragraphs/0", 0);
wordsApi.GetRunFontOnline(request);