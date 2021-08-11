var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestFileContentStream = File.OpenRead("Sample.docx");
var uploadRequest = new UploadFileRequest(requestFileContentStream, "Sample.docx");
wordsApi.UploadFile(uploadRequest);