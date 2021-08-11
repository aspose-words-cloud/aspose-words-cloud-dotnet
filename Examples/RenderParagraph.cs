var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var renderRequest = new RenderParagraphRequest("Sample.docx", "png", 0);
wordsApi.RenderParagraph(renderRequest);