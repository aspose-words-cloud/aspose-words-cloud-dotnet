var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteDocumentPropertyRequest("Sample.docx", "testProp");
wordsApi.DeleteDocumentProperty(deleteRequest);