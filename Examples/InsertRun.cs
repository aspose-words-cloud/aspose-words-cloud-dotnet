var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertRunRequest("Sample.docx", "paragraphs/1", new RunInsert()
{
    Text = "run with text"
});
wordsApi.InsertRun(insertRequest);