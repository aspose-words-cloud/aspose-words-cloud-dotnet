var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var updateRequest = new UpdateBookmarkRequest(remoteFileName, bookmarkName, new BookmarkData()
{
    Name = bookmarkName,
    Text = "This will be the text for Aspose"
}, destFileName: remoteFileName);
wordsApi.UpdateBookmark(updateRequest);