var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteMacrosOnlineRequest(requestDocumentStream);
wordsApi.DeleteMacrosOnline(deleteRequest);