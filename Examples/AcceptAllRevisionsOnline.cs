var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var fileName  = "test_doc.docx";

// Calls AcceptAllRevisionsOnline method for document in cloud.
using var documentStream = File.OpenRead(fileName);
var request = new AcceptAllRevisionsOnlineRequest(documentStream);
var acceptAllRevisionsOnlineResult = wordsApi.AcceptAllRevisionsOnline(request);
using (var fileStream = File.Create("test_result.docx"))
{
    acceptAllRevisionsOnlineResult.Document.CopyTo(fileStream);
}