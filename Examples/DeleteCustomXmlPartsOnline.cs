var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var deleteRequest = new DeleteCustomXmlPartsOnlineRequest(requestDocument);
wordsApi.DeleteCustomXmlPartsOnline(deleteRequest);