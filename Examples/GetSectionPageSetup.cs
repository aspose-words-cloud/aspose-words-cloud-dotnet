var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetSectionPageSetupRequest("Sample.docx", 0);
wordsApi.GetSectionPageSetup(request);