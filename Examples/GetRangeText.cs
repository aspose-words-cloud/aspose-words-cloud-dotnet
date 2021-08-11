var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetRangeTextRequest("Sample.docx", "id0.0.0", rangeEndIdentifier: "id0.0.1");
wordsApi.GetRangeText(request);