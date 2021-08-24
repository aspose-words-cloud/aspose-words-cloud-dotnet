var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteParagraphTabStopOnlineRequest(requestDocument, 72.0f, 0);
wordsApi.DeleteParagraphTabStopOnline(deleteRequest);