var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertCustomXmlPartRequest("Sample.docx", new CustomXmlPartInsert()
{
    Id = "hello",
    Data = "<data>Hello world</data>"
});
wordsApi.InsertCustomXmlPart(insertRequest);