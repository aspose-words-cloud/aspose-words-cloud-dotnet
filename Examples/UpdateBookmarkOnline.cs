var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateBookmarkOnlineRequest(requestDocumentStream, bookmarkName, new BookmarkData()
{
    Name = bookmarkName,
    Text = "This will be the text for Aspose"
}, destFileName: "Sample.docx");
wordsApi.UpdateBookmarkOnline(updateRequest);