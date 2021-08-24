var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetTableOnlineRequest(requestDocument, 1);
wordsApi.GetTableOnline(request);