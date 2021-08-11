var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentPropertyRequest("Sample.docx", "Author");
wordsApi.GetDocumentProperty(request);