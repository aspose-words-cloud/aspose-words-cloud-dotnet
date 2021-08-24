var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
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
var insertRequest = new InsertFormFieldRequest("Sample.docx", requestFormField);
wordsApi.InsertFormField(insertRequest);