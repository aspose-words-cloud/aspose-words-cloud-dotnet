var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var classifyRequest = new ClassifyDocumentRequest("Sample.docx", bestClassesCount: "3");
wordsApi.ClassifyDocument(classifyRequest);