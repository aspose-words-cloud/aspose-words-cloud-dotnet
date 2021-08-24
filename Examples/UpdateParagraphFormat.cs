var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestParagraphFormatDto = new ParagraphFormatUpdate()
{
    Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
};
var updateRequest = new UpdateParagraphFormatRequest("Sample.docx", 0, requestParagraphFormatDto);
wordsApi.UpdateParagraphFormat(updateRequest);