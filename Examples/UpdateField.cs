var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestField = new FieldUpdate()
{
    FieldCode = "{ NUMPAGES }"
};
var updateRequest = new UpdateFieldRequest("Sample.docx", 0, requestField, nodePath: "sections/0/paragraphs/0");
wordsApi.UpdateField(updateRequest);