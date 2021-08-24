var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestParagraphFormatDto = new ParagraphFormatUpdate()
{
    Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
};
var updateRequest = new UpdateParagraphFormatOnlineRequest(requestDocument, requestParagraphFormatDto, 0);
wordsApi.UpdateParagraphFormatOnline(updateRequest);