var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetCustomXmlPartRequest("Sample.docx", 0);
wordsApi.GetCustomXmlPart(request);