var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var convertRequest = new ConvertDocumentRequest(requestDocument, "pdf");
wordsApi.ConvertDocument(convertRequest);