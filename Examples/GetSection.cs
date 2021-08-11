var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetSectionRequest("Sample.docx", 0);
wordsApi.GetSection(request);