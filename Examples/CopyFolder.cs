var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var folderToCopy = "/TestCopyFolder";

var copyRequest = new CopyFolderRequest(folderToCopy + "Dest", folderToCopy + "Src");
wordsApi.CopyFolder(copyRequest);