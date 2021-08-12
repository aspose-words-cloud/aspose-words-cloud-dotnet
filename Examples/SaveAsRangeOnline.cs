var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.doc");
var saveRequest = new SaveAsRangeOnlineRequest(requestDocumentStream, "id0.0.0", new RangeDocument()
{
    DocumentName = "/NewDoc.docx"
}, rangeEndIdentifier: "id0.0.1");
wordsApi.SaveAsRangeOnline(saveRequest);