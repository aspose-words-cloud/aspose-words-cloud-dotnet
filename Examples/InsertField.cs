var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertFieldRequest("Sample.docx", new FieldInsert()
{
    FieldCode = "{ NUMPAGES }"
});
wordsApi.InsertField(insertRequest);