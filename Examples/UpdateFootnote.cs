var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateFootnoteRequest("Sample.docx", 0, new FootnoteUpdate()
{
    Text = "new text is here"
});
wordsApi.UpdateFootnote(updateRequest);