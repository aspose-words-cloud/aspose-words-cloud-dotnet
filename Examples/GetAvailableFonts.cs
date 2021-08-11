var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetAvailableFontsRequest();
wordsApi.GetAvailableFonts(request);