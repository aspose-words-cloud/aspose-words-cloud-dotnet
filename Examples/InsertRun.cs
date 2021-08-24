var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestRun = new RunInsert()
{
    Text = "run with text"
};
var insertRequest = new InsertRunRequest("Sample.docx", "paragraphs/1", requestRun);
wordsApi.InsertRun(insertRequest);