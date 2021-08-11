var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteCommentOnlineRequest(requestDocumentStream, 0);
wordsApi.DeleteCommentOnline(deleteRequest);