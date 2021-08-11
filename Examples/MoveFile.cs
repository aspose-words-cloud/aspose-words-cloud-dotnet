var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var moveRequest = new MoveFileRequest("/TestMoveFileDest_Sample.docx", "Sample.docx");
wordsApi.MoveFile(moveRequest);