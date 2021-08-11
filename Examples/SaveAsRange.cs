var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var saveRequest = new SaveAsRangeRequest("Sample.docx", "id0.0.0", new RangeDocument()
{
    DocumentName = "/NewDoc.docx"
}, rangeEndIdentifier: "id0.0.1");
wordsApi.SaveAsRange(saveRequest);