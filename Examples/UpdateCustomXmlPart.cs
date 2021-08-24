var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestCustomXmlPart = new CustomXmlPartUpdate()
{
    Data = "<data>Hello world</data>"
};
var updateRequest = new UpdateCustomXmlPartRequest("Sample.docx", 0, requestCustomXmlPart);
wordsApi.UpdateCustomXmlPart(updateRequest);