var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocument = File.OpenRead("compareTestDoc1.doc");
var requestCompareData = new CompareData()
{
    Author = "author",
    ComparingWithDocument = "TestCompareDocument2.doc",
    DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0)
};
using var requestComparingDocument = File.OpenRead("compareTestDoc2.doc");
var compareRequest = new CompareDocumentOnlineRequest(requestDocument, requestCompareData, comparingDocument: requestComparingDocument, destFileName: "/TestCompareDocumentOut.doc");
wordsApi.CompareDocumentOnline(compareRequest);