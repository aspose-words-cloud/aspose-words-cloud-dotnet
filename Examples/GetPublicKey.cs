var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetPublicKeyRequest();
wordsApi.GetPublicKey(request);