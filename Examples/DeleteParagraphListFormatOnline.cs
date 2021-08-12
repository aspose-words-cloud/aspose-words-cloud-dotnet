var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var deleteRequest = new DeleteParagraphListFormatOnlineRequest(requestDocumentStream, 0);
wordsApi.DeleteParagraphListFormatOnline(deleteRequest);