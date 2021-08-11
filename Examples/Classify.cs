var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var classifyRequest = new ClassifyRequest("Try text classification", bestClassesCount: "3");
wordsApi.Classify(classifyRequest);