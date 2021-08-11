var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetStyleRequest("Sample.docx", "Heading 1");
wordsApi.GetStyle(request);