var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/Footnote.doc");
var updateRequest = new UpdateFootnoteOnlineRequest(requestDocumentStream, new FootnoteUpdate()
{
    Text = "new text is here"
}, 0, nodePath: "");
wordsApi.UpdateFootnoteOnline(updateRequest);