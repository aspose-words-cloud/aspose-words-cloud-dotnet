var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertCustomXmlPartOnlineRequest(requestDocumentStream, new CustomXmlPartInsert()
{
    Id = "hello",
    Data = "<data>Hello world</data>"
});
wordsApi.InsertCustomXmlPartOnline(insertRequest);