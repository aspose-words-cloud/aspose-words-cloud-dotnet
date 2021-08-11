var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetCustomXmlPartsRequest("Sample.docx");
wordsApi.GetCustomXmlParts(request);