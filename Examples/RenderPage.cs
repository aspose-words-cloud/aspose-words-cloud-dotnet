var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var renderRequest = new RenderPageRequest("Sample.docx", 1, "bmp");
wordsApi.RenderPage(renderRequest);