var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateStyleOnlineRequest(requestDocumentStream, "Heading 1", new StyleUpdate()
{
    Name = "My Style"
});
wordsApi.UpdateStyleOnline(updateRequest);