var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestField = new FieldInsert()
{
    FieldCode = "{ NUMPAGES }"
};
var insertRequest = new InsertFieldRequest("Sample.docx", requestField);
wordsApi.InsertField(insertRequest);