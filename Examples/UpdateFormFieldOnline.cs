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
    TextInputDefault = "No name"
};
var updateRequest = new UpdateFormFieldOnlineRequest(requestDocument, requestFormField, 0, nodePath: "sections/0");
wordsApi.UpdateFormFieldOnline(updateRequest);