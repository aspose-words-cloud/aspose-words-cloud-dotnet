var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateFieldRequest("Sample.docx", 0, new FieldUpdate()
{
    FieldCode = "{ NUMPAGES }"
}, nodePath: "sections/0/paragraphs/0");
wordsApi.UpdateField(updateRequest);