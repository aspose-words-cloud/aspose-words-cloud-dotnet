var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("DocumentElements/HeaderFooters/HeadersFooters.doc");
var insertRequest = new InsertHeaderFooterOnlineRequest(requestDocumentStream, "", "FooterEven");
wordsApi.InsertHeaderFooterOnline(insertRequest);