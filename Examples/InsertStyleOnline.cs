var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertStyleOnlineRequest(requestDocumentStream, new StyleInsert()
{
    StyleName = "My Style",
    StyleType = StyleInsert.StyleTypeEnum.Paragraph
});
wordsApi.InsertStyleOnline(insertRequest);