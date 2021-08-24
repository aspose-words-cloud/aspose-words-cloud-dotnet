var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestListInsert = new ListInsert()
{
    Template = ListInsert.TemplateEnum.OutlineLegal
};
var insertRequest = new InsertListOnlineRequest(requestDocument, requestListInsert);
wordsApi.InsertListOnline(insertRequest);