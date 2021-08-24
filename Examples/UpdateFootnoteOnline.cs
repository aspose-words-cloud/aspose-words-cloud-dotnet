var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestFootnoteDto = new FootnoteUpdate()
{
    Text = "new text is here"
};
var updateRequest = new UpdateFootnoteOnlineRequest(requestDocument, requestFootnoteDto, 0);
wordsApi.UpdateFootnoteOnline(updateRequest);