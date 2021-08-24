var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestListFormatDto = new ListFormatUpdate()
{
    ListId = 2
};
var updateRequest = new UpdateParagraphListFormatOnlineRequest(requestDocument, requestListFormatDto, 0);
wordsApi.UpdateParagraphListFormatOnline(updateRequest);