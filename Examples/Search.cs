var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var searchRequest = new SearchRequest("Sample.docx", "aspose");
wordsApi.Search(searchRequest);