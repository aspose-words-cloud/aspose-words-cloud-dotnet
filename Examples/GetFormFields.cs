var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetFormFieldsRequest("Sample.docx");
wordsApi.GetFormFields(request);