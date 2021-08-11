var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var appendRequest = new AppendDocumentRequest(remoteFileName, new DocumentEntryList()
{
    DocumentEntries = new List<DocumentEntry>()
    {
        new DocumentEntry()
        {
            Href = remoteFileName,
            ImportFormatMode = "KeepSourceFormatting"
        }
    }
}, destFileName: remoteFileName);
wordsApi.AppendDocument(appendRequest);