var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var copyRequest = new CopyFileRequest("/TestCopyFileDest.docx", "Sample.docx");
wordsApi.CopyFile(copyRequest);