var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var searchRequest = new SearchOnlineRequest(requestDocument, "aspose");
wordsApi.SearchOnline(searchRequest);