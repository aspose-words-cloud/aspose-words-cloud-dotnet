var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var searchRequest = new SearchOnlineRequest(requestDocumentStream, "aspose");
wordsApi.SearchOnline(searchRequest);