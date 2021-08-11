var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentPropertiesRequest("Sample.docx");
wordsApi.GetDocumentProperties(request);