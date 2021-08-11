var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var deleteRequest = new DeleteSectionRequest("Sample.docx", 0);
wordsApi.DeleteSection(deleteRequest);