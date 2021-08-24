var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestFormField = new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "123",
    TextInputFormat = "UPPERCASE"
};
var insertRequest = new InsertFormFieldOnlineRequest(requestDocument, requestFormField, nodePath: "sections/0/paragraphs/0");
wordsApi.InsertFormFieldOnline(insertRequest);