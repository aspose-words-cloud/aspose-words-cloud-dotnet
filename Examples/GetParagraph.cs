var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetParagraphRequest("Sample.docx", 0);
wordsApi.GetParagraph(request);