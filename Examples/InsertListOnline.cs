var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var insertRequest = new InsertListOnlineRequest(requestDocumentStream, new ListInsert()
{
    Template = ListInsert.TemplateEnum.OutlineLegal
});
wordsApi.InsertListOnline(insertRequest);