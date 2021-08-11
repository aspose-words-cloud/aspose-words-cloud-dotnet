var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteFolderRequest("");
wordsApi.DeleteFolder(deleteRequest);