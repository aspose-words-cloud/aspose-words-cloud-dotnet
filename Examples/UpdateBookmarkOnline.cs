var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var bookmarkName = "aspose";

using var requestDocument = File.OpenRead("Sample.docx");
var requestBookmarkData = new BookmarkData()
{
    Name = bookmarkName,
    Text = "This will be the text for Aspose"
};
var updateRequest = new UpdateBookmarkOnlineRequest(requestDocument, bookmarkName, requestBookmarkData, destFileName: "Sample.docx");
wordsApi.UpdateBookmarkOnline(updateRequest);