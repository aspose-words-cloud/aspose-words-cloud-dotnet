var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var requestDocumentListDocumentEntries0 = new DocumentEntry()
{
    Href = remoteFileName,
    ImportFormatMode = "KeepSourceFormatting"
};
var requestDocumentListDocumentEntries = new List<DocumentEntry>()
{
    requestDocumentListDocumentEntries0
};
var requestDocumentList = new DocumentEntryList()
{
    DocumentEntries = requestDocumentListDocumentEntries
};
var appendRequest = new AppendDocumentRequest(remoteFileName, requestDocumentList);
wordsApi.AppendDocument(appendRequest);