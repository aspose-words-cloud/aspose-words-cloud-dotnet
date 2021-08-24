var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestParagraph = new ParagraphInsert()
{
    Text = "This is a new paragraph for your document"
};
var insertRequest = new InsertParagraphRequest("Sample.docx", requestParagraph);
wordsApi.InsertParagraph(insertRequest);