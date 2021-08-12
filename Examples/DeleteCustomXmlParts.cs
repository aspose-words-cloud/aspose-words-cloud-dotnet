var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteCustomXmlPartsRequest("Sample.docx");
wordsApi.DeleteCustomXmlParts(deleteRequest);