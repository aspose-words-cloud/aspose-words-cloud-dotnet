var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestStyleCopy = new StyleCopy()
{
    StyleName = "Heading 1"
};
var copyRequest = new CopyStyleRequest("Sample.docx", requestStyleCopy);
wordsApi.CopyStyle(copyRequest);