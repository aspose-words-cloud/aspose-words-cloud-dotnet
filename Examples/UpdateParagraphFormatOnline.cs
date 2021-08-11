var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateParagraphFormatOnlineRequest(requestDocumentStream, new ParagraphFormatUpdate()
{
    Alignment = ParagraphFormatUpdate.AlignmentEnum.Right
}, 0, nodePath: "");
wordsApi.UpdateParagraphFormatOnline(updateRequest);