var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var mailMergeRequest = new ExecuteMailMergeRequest("Sample.docx", data: "TestExecuteTemplateData.txt");
wordsApi.ExecuteMailMerge(mailMergeRequest);