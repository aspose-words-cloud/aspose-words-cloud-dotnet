var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var splitRequest = new SplitDocumentOnlineRequest(requestDocumentStream, "text", destFileName: "/TestSplitDocument.text", from: 1, to: 2);
wordsApi.SplitDocumentOnline(splitRequest);