var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestCustomXmlPart = new CustomXmlPartInsert()
{
    Id = "hello",
    Data = "<data>Hello world</data>"
};
var insertRequest = new InsertCustomXmlPartOnlineRequest(requestDocument, requestCustomXmlPart);
wordsApi.InsertCustomXmlPartOnline(insertRequest);