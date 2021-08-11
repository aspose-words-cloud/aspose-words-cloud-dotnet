var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetBookmarksRequest("Sample.docx");
wordsApi.GetBookmarks(request);