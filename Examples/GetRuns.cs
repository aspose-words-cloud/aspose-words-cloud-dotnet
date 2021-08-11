var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var request = new GetRunsRequest("Sample.docx", "sections/0/paragraphs/0");
wordsApi.GetRuns(request);