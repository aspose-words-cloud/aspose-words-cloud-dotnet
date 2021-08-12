var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertFormFieldRequest("Sample.docx", new FormFieldTextInput()
{
    Name = "FullName",
    Enabled = true,
    CalculateOnExit = true,
    StatusText = "",
    TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular,
    TextInputDefault = "123",
    TextInputFormat = "UPPERCASE"
});
wordsApi.InsertFormField(insertRequest);