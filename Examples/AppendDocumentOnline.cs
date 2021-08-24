var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestDocumentListDocumentEntries0 = new DocumentEntry()
{
    Href = "Sample.docx",
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
var appendRequest = new AppendDocumentOnlineRequest(requestDocument, requestDocumentList);
wordsApi.AppendDocumentOnline(appendRequest);