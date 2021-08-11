var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var request = new GetStyleFromDocumentElementOnlineRequest(requestDocumentStream, "paragraphs/1/paragraphFormat");
wordsApi.GetStyleFromDocumentElementOnline(request);