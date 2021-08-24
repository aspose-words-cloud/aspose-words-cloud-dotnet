var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestTemplate = File.OpenRead("Sample.docx");
var request = new GetDocumentFieldNamesOnlineRequest(requestTemplate, useNonMergeFields: true);
wordsApi.GetDocumentFieldNamesOnline(request);