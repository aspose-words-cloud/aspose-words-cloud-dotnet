var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var rejectRequest = new RejectAllRevisionsOnlineRequest(requestDocumentStream);
wordsApi.RejectAllRevisionsOnline(rejectRequest);