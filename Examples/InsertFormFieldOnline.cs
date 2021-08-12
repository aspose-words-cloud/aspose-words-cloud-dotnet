var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var insertRequest = new InsertFormFieldOnlineRequest(requestDocumentStream, new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "123",
    TextInputFormat = "UPPERCASE"
}, nodePath: "sections/0/paragraphs/0");
wordsApi.InsertFormFieldOnline(insertRequest);