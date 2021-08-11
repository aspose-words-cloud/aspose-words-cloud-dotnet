var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetBookmarkByNameRequest("Sample.docx", "aspose");
wordsApi.GetBookmarkByName(request);