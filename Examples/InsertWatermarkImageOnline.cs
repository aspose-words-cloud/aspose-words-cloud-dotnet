var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
using var requestImageFileStream = File.OpenRead("Common/aspose-cloud.png");
var insertRequest = new InsertWatermarkImageOnlineRequest(requestDocumentStream, requestImageFileStream);
wordsApi.InsertWatermarkImageOnline(insertRequest);