var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteParagraphTabStopOnlineRequest(requestDocumentStream, 72.0f, 0);
wordsApi.DeleteParagraphTabStopOnline(deleteRequest);