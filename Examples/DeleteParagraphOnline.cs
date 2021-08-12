var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteParagraphOnlineRequest(requestDocumentStream, 0);
wordsApi.DeleteParagraphOnline(deleteRequest);