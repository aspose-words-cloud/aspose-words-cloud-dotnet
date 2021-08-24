var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetStyleFromDocumentElementOnlineRequest(requestDocument, "paragraphs/1/paragraphFormat");
wordsApi.GetStyleFromDocumentElementOnline(request);