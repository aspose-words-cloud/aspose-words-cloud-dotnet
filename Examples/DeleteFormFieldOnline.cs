var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/FormFilled.docx");
var deleteRequest = new DeleteFormFieldOnlineRequest(requestDocumentStream, 0, nodePath: "sections/0");
wordsApi.DeleteFormFieldOnline(deleteRequest);