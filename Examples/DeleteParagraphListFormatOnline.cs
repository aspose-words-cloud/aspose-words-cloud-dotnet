var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/ParagraphDeleteListFormat.doc");
var deleteRequest = new DeleteParagraphListFormatOnlineRequest(requestDocumentStream, 0, nodePath: "");
wordsApi.DeleteParagraphListFormatOnline(deleteRequest);