var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/ParagraphUpdateListFormat.doc");
var updateRequest = new UpdateParagraphListFormatOnlineRequest(requestDocumentStream, new ListFormatUpdate()
{
    ListId = 2
}, 0, nodePath: "");
wordsApi.UpdateParagraphListFormatOnline(updateRequest);