var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var classifyRequest = new ClassifyDocumentOnlineRequest(requestDocumentStream, bestClassesCount: "3");
wordsApi.ClassifyDocumentOnline(classifyRequest);