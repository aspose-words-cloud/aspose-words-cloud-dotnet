var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertListRequest("TestGetLists.doc", new ListInsert()
{
    Template = ListInsert.TemplateEnum.OutlineLegal
});
wordsApi.InsertList(insertRequest);