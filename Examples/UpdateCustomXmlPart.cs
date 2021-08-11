var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateCustomXmlPartRequest("Sample.docx", 0, new CustomXmlPartUpdate()
{
    Data = "<data>Hello world</data>"
});
wordsApi.UpdateCustomXmlPart(updateRequest);