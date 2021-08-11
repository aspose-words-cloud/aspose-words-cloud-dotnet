var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetParagraphTabStopsRequest("Sample.docx", 0);
wordsApi.GetParagraphTabStops(request);