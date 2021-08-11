var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/GetField.docx");
var updateRequest = new UpdateFieldOnlineRequest(requestDocumentStream, new FieldUpdate()
{
    FieldCode = "{ NUMPAGES }"
}, 0, nodePath: "sections/0/paragraphs/0");
wordsApi.UpdateFieldOnline(updateRequest);