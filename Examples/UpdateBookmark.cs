var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";
var bookmarkName = "aspose";

var updateBookmark = new UpdateBookmarkRequest(remoteFileName, bookmarkName, new BookmarkData()
{
    Name = bookmarkName,
    Text = "New Bookmark Text"
});
wordsApi.UpdateBookmark(updateBookmark);