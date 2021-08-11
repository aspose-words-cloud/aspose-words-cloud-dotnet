var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var renderRequest = new RenderMathObjectRequest("Sample.docx", "png", 0);
wordsApi.RenderMathObject(renderRequest);