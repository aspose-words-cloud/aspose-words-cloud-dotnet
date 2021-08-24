var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var updateRequest = new UpdateFieldsOnlineRequest(requestDocument);
wordsApi.UpdateFieldsOnline(updateRequest);