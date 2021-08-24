var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestTabStopInsertDto = new TabStopInsert()
{
    Alignment = TabStopInsert.AlignmentEnum.Left,
    Leader = TabStopInsert.LeaderEnum.None,
    Position = 72f
};
var insertRequest = new InsertOrUpdateParagraphTabStopOnlineRequest(requestDocument, requestTabStopInsertDto, 0);
wordsApi.InsertOrUpdateParagraphTabStopOnline(insertRequest);