var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetFormFieldsOnlineRequest(requestDocument, nodePath: "sections/0");
wordsApi.GetFormFieldsOnline(request);