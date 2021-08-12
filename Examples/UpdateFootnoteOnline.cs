var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var updateRequest = new UpdateFootnoteOnlineRequest(requestDocumentStream, new FootnoteUpdate()
{
    Text = "new text is here"
}, 0);
wordsApi.UpdateFootnoteOnline(updateRequest);