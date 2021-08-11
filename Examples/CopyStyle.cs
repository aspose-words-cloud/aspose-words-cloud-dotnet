var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var copyRequest = new CopyStyleRequest("Sample.docx", new StyleCopy()
{
    StyleName = "Heading 1"
});
wordsApi.CopyStyle(copyRequest);