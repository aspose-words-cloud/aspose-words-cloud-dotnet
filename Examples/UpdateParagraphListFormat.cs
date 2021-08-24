var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestListFormatDto = new ListFormatUpdate()
{
    ListId = 2
};
var updateRequest = new UpdateParagraphListFormatRequest("Sample.docx", 0, requestListFormatDto);
wordsApi.UpdateParagraphListFormat(updateRequest);