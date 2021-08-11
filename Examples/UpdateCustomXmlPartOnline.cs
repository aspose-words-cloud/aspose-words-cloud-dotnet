var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateCustomXmlPartOnlineRequest(requestDocumentStream, 0, new CustomXmlPartUpdate()
{
    Data = "<data>Hello world</data>"
});
wordsApi.UpdateCustomXmlPartOnline(updateRequest);