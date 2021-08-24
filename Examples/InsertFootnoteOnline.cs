var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestFootnoteDto = new FootnoteInsert()
{
    FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
    Text = "test endnote"
};
var insertRequest = new InsertFootnoteOnlineRequest(requestDocument, requestFootnoteDto);
wordsApi.InsertFootnoteOnline(insertRequest);