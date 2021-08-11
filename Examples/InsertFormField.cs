var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var remoteFileName = "Sample.docx";

var insertRequest = new InsertFormFieldRequest(remoteFileName, new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "123",
    TextInputFormat = "UPPERCASE"
}, destFileName: remoteFileName);
wordsApi.InsertFormField(insertRequest);