var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetOfficeMathObjectsRequest("Sample.docx");
wordsApi.GetOfficeMathObjects(request);