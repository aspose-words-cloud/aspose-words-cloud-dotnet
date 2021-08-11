var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/GetField.docx");
var deleteRequest = new DeleteFieldOnlineRequest(requestDocumentStream, 0, nodePath: "sections/0/paragraphs/0");
wordsApi.DeleteFieldOnline(deleteRequest);