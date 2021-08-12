var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var insertRequest = new InsertFootnoteOnlineRequest(requestDocumentStream, new FootnoteInsert()
{
    FootnoteType = FootnoteInsert.FootnoteTypeEnum.Endnote,
    Text = "test endnote"
});
wordsApi.InsertFootnoteOnline(insertRequest);