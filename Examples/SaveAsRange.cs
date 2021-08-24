var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestDocumentParameters = new RangeDocument()
{
    DocumentName = "/NewDoc.docx"
};
var saveRequest = new SaveAsRangeRequest("Sample.docx", "id0.0.0", requestDocumentParameters, rangeEndIdentifier: "id0.0.1");
wordsApi.SaveAsRange(saveRequest);