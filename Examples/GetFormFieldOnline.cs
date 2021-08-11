var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/FormFilled.docx");
var request = new GetFormFieldOnlineRequest(requestDocumentStream, 0, nodePath: "sections/0");
wordsApi.GetFormFieldOnline(request);