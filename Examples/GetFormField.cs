var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetFormFieldRequest("Sample.docx", 0);
wordsApi.GetFormField(request);