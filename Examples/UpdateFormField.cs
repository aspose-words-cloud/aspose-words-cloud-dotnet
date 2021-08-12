var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var updateRequest = new UpdateFormFieldRequest("Sample.docx", 0, new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "No name"
});
wordsApi.UpdateFormField(updateRequest);