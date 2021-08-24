var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestTabStopInsertDto = new TabStopInsert()
{
    Alignment = TabStopInsert.AlignmentEnum.Left,
    Leader = TabStopInsert.LeaderEnum.None,
    Position = 100.0f
};
var insertRequest = new InsertOrUpdateParagraphTabStopRequest("Sample.docx", 0, requestTabStopInsertDto);
wordsApi.InsertOrUpdateParagraphTabStop(insertRequest);