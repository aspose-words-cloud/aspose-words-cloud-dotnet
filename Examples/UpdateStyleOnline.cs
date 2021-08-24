var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestStyleUpdate = new StyleUpdate()
{
    Name = "My Style"
};
var updateRequest = new UpdateStyleOnlineRequest(requestDocument, "Heading 1", requestStyleUpdate);
wordsApi.UpdateStyleOnline(updateRequest);