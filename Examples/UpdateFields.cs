var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateFieldsRequest("Sample.docx");
wordsApi.UpdateFields(updateRequest);