var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetFormFieldOnlineRequest(requestDocument, 0, nodePath: "sections/0");
wordsApi.GetFormFieldOnline(request);