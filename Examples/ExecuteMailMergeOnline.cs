var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestTemplateStream = File.OpenRead("TestExecuteTemplate.doc");
using var requestDataStream = File.OpenRead("TestExecuteTemplateData.txt");
var mailMergeRequest = new ExecuteMailMergeOnlineRequest(requestTemplateStream, requestDataStream);
wordsApi.ExecuteMailMergeOnline(mailMergeRequest);