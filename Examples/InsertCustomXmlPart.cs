var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestCustomXmlPart = new CustomXmlPartInsert()
{
    Id = "hello",
    Data = "<data>Hello world</data>"
};
var insertRequest = new InsertCustomXmlPartRequest("Sample.docx", requestCustomXmlPart);
wordsApi.InsertCustomXmlPart(insertRequest);