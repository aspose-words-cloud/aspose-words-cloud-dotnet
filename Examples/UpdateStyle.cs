var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateStyleRequest("Sample.docx", "Heading 1", new StyleUpdate()
{
    Name = "My Style"
});
wordsApi.UpdateStyle(updateRequest);