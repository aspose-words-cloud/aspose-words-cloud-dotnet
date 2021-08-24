var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestFootnoteDto = new FootnoteInsert()
{
    FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
    Text = "test endnote"
};
var insertRequest = new InsertFootnoteRequest("Sample.docx", requestFootnoteDto);
wordsApi.InsertFootnote(insertRequest);