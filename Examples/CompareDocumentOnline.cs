var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("compareTestDoc1.doc");
using var requestComparingDocumentStream = File.OpenRead("compareTestDoc2.doc");
var compareRequest = new CompareDocumentOnlineRequest(requestDocumentStream, new CompareData()
{
    Author = "author",
    ComparingWithDocument = "TestCompareDocument2.doc",
    DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0)
}, comparingDocument: requestComparingDocumentStream, destFileName: "/TestCompareDocumentOut.doc");
wordsApi.CompareDocumentOnline(compareRequest);