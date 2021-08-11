var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetDocumentWithFormatRequest("Sample.docx", "text", outPath: "/TestGetDocumentWithFormatAndOutPath.text");
wordsApi.GetDocumentWithFormat(request);