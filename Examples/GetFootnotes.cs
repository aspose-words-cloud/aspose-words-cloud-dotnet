var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetFootnotesRequest("Sample.docx");
wordsApi.GetFootnotes(request);