var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestCustomXmlPart = new CustomXmlPartUpdate()
{
    Data = "<data>Hello world</data>"
};
var updateRequest = new UpdateCustomXmlPartOnlineRequest(requestDocument, 0, requestCustomXmlPart);
wordsApi.UpdateCustomXmlPartOnline(updateRequest);