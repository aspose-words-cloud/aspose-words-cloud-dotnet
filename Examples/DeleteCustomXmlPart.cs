var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteCustomXmlPartRequest("Sample.docx", 0);
wordsApi.DeleteCustomXmlPart(deleteRequest);