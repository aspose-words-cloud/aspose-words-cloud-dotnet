var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var moveRequest = new MoveFolderRequest("/TestMoveFolderDest_Sample", "/TestMoveFolderSrc");
wordsApi.MoveFolder(moveRequest);