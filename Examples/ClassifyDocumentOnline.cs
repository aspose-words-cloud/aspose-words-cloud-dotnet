var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var classifyRequest = new ClassifyDocumentOnlineRequest(requestDocument, bestClassesCount: "3");
wordsApi.ClassifyDocumentOnline(classifyRequest);