var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestFileContent = File.OpenRead("Sample.docx");
var uploadRequest = new UploadFileRequest(requestFileContent, "Sample.docx");
wordsApi.UploadFile(uploadRequest);