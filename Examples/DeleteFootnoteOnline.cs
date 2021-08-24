var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var deleteRequest = new DeleteFootnoteOnlineRequest(requestDocument, 0);
wordsApi.DeleteFootnoteOnline(deleteRequest);