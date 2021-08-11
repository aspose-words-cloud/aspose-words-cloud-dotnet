var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var downloadRequest = new DownloadFileRequest("Sample.docx");
wordsApi.DownloadFile(downloadRequest);