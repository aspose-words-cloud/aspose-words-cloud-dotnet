var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestStyleApply = new StyleApply()
{
    StyleName = "Heading 1"
};
var applyStyleRequest = new ApplyStyleToDocumentElementOnlineRequest(requestDocument, "paragraphs/1/paragraphFormat", requestStyleApply);
wordsApi.ApplyStyleToDocumentElementOnline(applyStyleRequest);