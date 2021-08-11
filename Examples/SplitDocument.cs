var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var splitRequest = new SplitDocumentRequest("Sample.docx", "text", destFileName: "/TestSplitDocument.text", from: 1, to: 2);
wordsApi.SplitDocument(splitRequest);