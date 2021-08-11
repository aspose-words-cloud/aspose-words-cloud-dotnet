var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var resetRequest = new ResetCacheRequest();
wordsApi.ResetCache(resetRequest);