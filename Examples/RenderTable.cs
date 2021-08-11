var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var renderRequest = new RenderTableRequest("Sample.docx", "png", 0);
wordsApi.RenderTable(renderRequest);