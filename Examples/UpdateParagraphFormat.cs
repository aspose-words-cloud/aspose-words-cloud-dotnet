var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateParagraphFormatRequest("Sample.docx", 0, new ParagraphFormatUpdate()
{
    Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
});
wordsApi.UpdateParagraphFormat(updateRequest);