var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestStyleInsert = new StyleInsert()
{
    StyleName = "My Style",
    StyleType = StyleInsert.StyleTypeEnum.Paragraph
};
var insertRequest = new InsertStyleOnlineRequest(requestDocument, requestStyleInsert);
wordsApi.InsertStyleOnline(insertRequest);