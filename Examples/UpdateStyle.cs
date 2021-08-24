var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestStyleUpdate = new StyleUpdate()
{
    Name = "My Style"
};
var updateRequest = new UpdateStyleRequest("Sample.docx", "Heading 1", requestStyleUpdate);
wordsApi.UpdateStyle(updateRequest);