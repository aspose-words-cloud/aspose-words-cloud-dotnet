var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestField = new FieldUpdate()
{
    FieldCode = "{ NUMPAGES }"
};
var updateRequest = new UpdateFieldOnlineRequest(requestDocument, requestField, 0, nodePath: "sections/0/paragraphs/0");
wordsApi.UpdateFieldOnline(updateRequest);