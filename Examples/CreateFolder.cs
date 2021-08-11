var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var createRequest = new CreateFolderRequest("/TestCreateFolder");
wordsApi.CreateFolder(createRequest);