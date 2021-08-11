var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertStyleRequest("Sample.docx", new StyleInsert()
{
    StyleName = "My Style",
    StyleType = StyleInsert.StyleTypeEnum.Paragraph
});
wordsApi.InsertStyle(insertRequest);