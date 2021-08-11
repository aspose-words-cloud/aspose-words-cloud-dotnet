var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertHeaderFooterRequest("Sample.docx", "", "FooterEven");
wordsApi.InsertHeaderFooter(insertRequest);