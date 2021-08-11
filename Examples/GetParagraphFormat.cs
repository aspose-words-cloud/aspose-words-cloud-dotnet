var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetParagraphFormatRequest("Sample.docx", 0);
wordsApi.GetParagraphFormat(request);