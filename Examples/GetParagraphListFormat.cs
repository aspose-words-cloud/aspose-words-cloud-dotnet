var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetParagraphListFormatRequest("Sample.docx", 0);
wordsApi.GetParagraphListFormat(request);