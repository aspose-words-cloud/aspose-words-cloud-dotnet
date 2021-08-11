var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateParagraphListFormatRequest("Sample.docx", 0, new ListFormatUpdate()
{
    ListId = 2
});
wordsApi.UpdateParagraphListFormat(updateRequest);