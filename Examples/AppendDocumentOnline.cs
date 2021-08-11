var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var appendRequest = new AppendDocumentOnlineRequest(requestDocumentStream, new DocumentEntryList()
{
    DocumentEntries = new List<DocumentEntry>()
    {
        new DocumentEntry()
        {
            Href = "Sample.docx",
            ImportFormatMode = "KeepSourceFormatting"
        }
    }
});
wordsApi.AppendDocumentOnline(appendRequest);