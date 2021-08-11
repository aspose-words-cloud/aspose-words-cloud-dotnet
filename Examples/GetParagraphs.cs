var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetParagraphsRequest("Sample.docx");
wordsApi.GetParagraphs(request);