var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var createRequest = new CreateDocumentRequest(fileName: "Sample.docx");
wordsApi.CreateDocument(createRequest);