var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var applyStyleRequest = new ApplyStyleToDocumentElementRequest("Sample.docx", "paragraphs/1/paragraphFormat", new StyleApply()
{
    StyleName = "Heading 1"
});
wordsApi.ApplyStyleToDocumentElement(applyStyleRequest);