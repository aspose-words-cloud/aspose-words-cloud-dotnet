var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var applyStyleRequest = new ApplyStyleToDocumentElementOnlineRequest(requestDocumentStream, "paragraphs/1/paragraphFormat", new StyleApply()
{
    StyleName = "Heading 1"
});
wordsApi.ApplyStyleToDocumentElementOnline(applyStyleRequest);