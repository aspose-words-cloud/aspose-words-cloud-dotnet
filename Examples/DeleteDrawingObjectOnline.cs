var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteDrawingObjectOnlineRequest(requestDocumentStream, 0);
wordsApi.DeleteDrawingObjectOnline(deleteRequest);