var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var removeRequest = new RemoveRangeRequest("Sample.docx", "id0.0.0", rangeEndIdentifier: "id0.0.1");
wordsApi.RemoveRange(removeRequest);