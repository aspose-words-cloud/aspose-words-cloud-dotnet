var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("Sample.docx");
var requestCell = new TableCellInsert()
{
};
var insertRequest = new InsertTableCellOnlineRequest(requestDocument, "sections/0/tables/2/rows/0", requestCell);
wordsApi.InsertTableCellOnline(insertRequest);