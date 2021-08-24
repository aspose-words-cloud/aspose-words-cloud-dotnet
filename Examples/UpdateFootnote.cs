var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestFootnoteDto = new FootnoteUpdate()
{
    Text = "new text is here"
};
var updateRequest = new UpdateFootnoteRequest("Sample.docx", 0, requestFootnoteDto);
wordsApi.UpdateFootnote(updateRequest);