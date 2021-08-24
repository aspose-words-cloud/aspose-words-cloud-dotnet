var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestFormField = new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "No name"
};
var updateRequest = new UpdateFormFieldRequest("Sample.docx", 0, requestFormField);
wordsApi.UpdateFormField(updateRequest);