var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var mailMergeRequest = new ExecuteMailMergeRequest(remoteFileName, data: "TestExecuteTemplateData.txt", destFileName: remoteFileName);
wordsApi.ExecuteMailMerge(mailMergeRequest);