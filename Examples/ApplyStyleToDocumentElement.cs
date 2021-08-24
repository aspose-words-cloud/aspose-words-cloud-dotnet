var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestStyleApply = new StyleApply()
{
    StyleName = "Heading 1"
};
var applyStyleRequest = new ApplyStyleToDocumentElementRequest("Sample.docx", "paragraphs/1/paragraphFormat", requestStyleApply);
wordsApi.ApplyStyleToDocumentElement(applyStyleRequest);