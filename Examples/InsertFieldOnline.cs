var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertFieldOnlineRequest(requestDocumentStream, new FieldInsert()
{
    FieldCode = "{ NUMPAGES }"
}, nodePath: "sections/0/paragraphs/0");
wordsApi.InsertFieldOnline(insertRequest);