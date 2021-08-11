var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var renderRequest = new RenderDrawingObjectRequest("Sample.docx", "png", 0);
wordsApi.RenderDrawingObject(renderRequest);