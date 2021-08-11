var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertParagraphRequest("Sample.docx", new ParagraphInsert()
{
    Text = "This is a new paragraph for your document"
});
wordsApi.InsertParagraph(insertRequest);