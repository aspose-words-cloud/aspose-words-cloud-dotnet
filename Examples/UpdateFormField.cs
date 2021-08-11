var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var updateRequest = new UpdateFormFieldRequest(remoteFileName, 0, new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "No name"
}, destFileName: remoteFileName);
wordsApi.UpdateFormField(updateRequest);