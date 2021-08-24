var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestCompareData = new CompareData()
{
    Author = "author",
    ComparingWithDocument = "TestCompareDocument2.doc",
    DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0)
};
var compareRequest = new CompareDocumentRequest("TestCompareDocument1.doc", requestCompareData, destFileName: "/TestCompareDocumentOut.doc");
wordsApi.CompareDocument(compareRequest);