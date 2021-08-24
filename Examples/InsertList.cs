var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestListInsert = new ListInsert()
{
    Template = ListInsert.TemplateEnum.OutlineLegal
};
var insertRequest = new InsertListRequest("TestGetLists.doc", requestListInsert);
wordsApi.InsertList(insertRequest);