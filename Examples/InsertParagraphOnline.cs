var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertParagraphOnlineRequest(requestDocumentStream, new ParagraphInsert()
{
    Text = "This is a new paragraph for your document"
}, nodePath: "sections/0");
wordsApi.InsertParagraphOnline(insertRequest);