var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var bookmarkName = "aspose";

var updateRequest = new UpdateBookmarkRequest("Sample.docx", bookmarkName, new BookmarkData()
{
    Name = bookmarkName,
    Text = "This will be the text for Aspose"
});
wordsApi.UpdateBookmark(updateRequest);