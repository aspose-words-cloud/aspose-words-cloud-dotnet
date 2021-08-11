var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetOfficeMathObjectRequest("Sample.docx", 0);
wordsApi.GetOfficeMathObject(request);