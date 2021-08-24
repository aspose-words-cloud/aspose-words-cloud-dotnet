var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestStyleInsert = new StyleInsert()
{
    StyleName = "My Style",
    StyleType = StyleInsert.StyleTypeEnum.Paragraph
};
var insertRequest = new InsertStyleRequest("Sample.docx", requestStyleInsert);
wordsApi.InsertStyle(insertRequest);