var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteFileRequest("Sample.docx");
wordsApi.DeleteFile(deleteRequest);