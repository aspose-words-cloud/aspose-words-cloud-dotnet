var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
using var requestImageFile = File.OpenRead("Common/aspose-cloud.png");
var insertRequest = new InsertWatermarkImageOnlineRequest(requestDocument, requestImageFile);
wordsApi.InsertWatermarkImageOnline(insertRequest);