var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/test_uploadfile.docx");
var convertRequest = new ConvertDocumentRequest(requestDocumentStream, "pdf");
wordsApi.ConvertDocument(convertRequest);