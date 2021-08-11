var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/FormFilled.docx");
var updateRequest = new UpdateFormFieldOnlineRequest(requestDocumentStream, new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "No name"
}, 0, nodePath: "sections/0");
wordsApi.UpdateFormFieldOnline(updateRequest);