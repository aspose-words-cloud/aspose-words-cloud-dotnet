var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.doc");
var requestDocumentParameters = new RangeDocument()
{
    DocumentName = "/NewDoc.docx"
};
var saveRequest = new SaveAsRangeOnlineRequest(requestDocument, "id0.0.0", requestDocumentParameters, rangeEndIdentifier: "id0.0.1");
wordsApi.SaveAsRangeOnline(saveRequest);