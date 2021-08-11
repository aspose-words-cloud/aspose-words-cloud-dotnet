var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertFootnoteRequest("Sample.docx", new FootnoteInsert()
{
    FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
    Text = "test endnote"
});
wordsApi.InsertFootnote(insertRequest);