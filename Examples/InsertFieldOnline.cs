var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestField = new FieldInsert()
{
    FieldCode = "{ NUMPAGES }"
};
var insertRequest = new InsertFieldOnlineRequest(requestDocument, requestField, nodePath: "sections/0/paragraphs/0");
wordsApi.InsertFieldOnline(insertRequest);