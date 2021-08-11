var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateFieldsOnlineRequest(requestDocumentStream);
wordsApi.UpdateFieldsOnline(updateRequest);