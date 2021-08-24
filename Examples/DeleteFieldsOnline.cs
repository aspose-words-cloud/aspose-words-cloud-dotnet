var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteFieldsOnlineRequest(requestDocument);
wordsApi.DeleteFieldsOnline(deleteRequest);