var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var bookmarkName = "aspose";

var requestBookmarkData = new BookmarkData()
{
    Name = bookmarkName,
    Text = "This will be the text for Aspose"
};
var updateRequest = new UpdateBookmarkRequest("Sample.docx", bookmarkName, requestBookmarkData);
wordsApi.UpdateBookmark(updateRequest);