var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestTemplateStream = File.OpenRead("Sample.docx");
var request = new GetDocumentFieldNamesOnlineRequest(requestTemplateStream, useNonMergeFields: true);
wordsApi.GetDocumentFieldNamesOnline(request);