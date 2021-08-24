var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var request = new GetTableRowFormatOnlineRequest(requestDocument, "sections/0/tables/2", 0);
wordsApi.GetTableRowFormatOnline(request);