var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/FormFilled.docx");
var request = new GetFormFieldsOnlineRequest(requestDocumentStream, nodePath: "sections/0");
wordsApi.GetFormFieldsOnline(request);