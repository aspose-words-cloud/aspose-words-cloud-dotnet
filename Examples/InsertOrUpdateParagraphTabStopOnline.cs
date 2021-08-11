var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("/ParagraphTabStops.docx");
var insertRequest = new InsertOrUpdateParagraphTabStopOnlineRequest(requestDocumentStream, new TabStopInsert()
{
    Alignment = TabStopInsert.AlignmentEnum.Left,
    Leader = TabStopInsert.LeaderEnum.None,
    Position = 72f
}, 0, nodePath: "");
wordsApi.InsertOrUpdateParagraphTabStopOnline(insertRequest);