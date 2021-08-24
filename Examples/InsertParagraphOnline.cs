var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestParagraph = new ParagraphInsert()
{
    Text = "This is a new paragraph for your document"
};
var insertRequest = new InsertParagraphOnlineRequest(requestDocument, requestParagraph, nodePath: "sections/0");
wordsApi.InsertParagraphOnline(insertRequest);