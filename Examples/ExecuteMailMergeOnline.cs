var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestTemplate = File.OpenRead("TestExecuteTemplate.doc");
using var requestData = File.OpenRead("TestExecuteTemplateData.txt");
var mailMergeRequest = new ExecuteMailMergeOnlineRequest(requestTemplate, requestData);
wordsApi.ExecuteMailMergeOnline(mailMergeRequest);