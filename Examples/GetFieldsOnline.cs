var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetFieldsOnlineRequest(requestDocumentStream, nodePath: "sections/0");
wordsApi.GetFieldsOnline(request);