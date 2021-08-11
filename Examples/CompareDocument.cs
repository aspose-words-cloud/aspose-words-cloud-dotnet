var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var compareRequest = new CompareDocumentRequest("TestCompareDocument1.doc", new CompareData()
{
    Author = "author",
    ComparingWithDocument = "TestCompareDocument2.doc",
    DateTime = new System.DateTime(2015, 10, 26, 0, 0, 0)
}, destFileName: "/TestCompareDocumentOut.doc");
wordsApi.CompareDocument(compareRequest);