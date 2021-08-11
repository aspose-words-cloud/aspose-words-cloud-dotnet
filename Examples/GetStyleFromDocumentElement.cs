var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetStyleFromDocumentElementRequest("Sample.docx", "paragraphs/1/paragraphFormat");
wordsApi.GetStyleFromDocumentElement(request);