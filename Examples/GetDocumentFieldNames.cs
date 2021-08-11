var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentFieldNamesRequest("Sample.docx");
wordsApi.GetDocumentFieldNames(request);