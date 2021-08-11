var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var insertRequest = new InsertCommentRequest("Sample.docx", new CommentInsert()
{
    RangeStart = new DocumentPosition()
    {
        Node = new NodeLink()
        {
            NodeId = "0.3.0.3"
        },
        Offset = 0
    },
    RangeEnd = new DocumentPosition()
    {
        Node = new NodeLink()
        {
            NodeId = "0.3.0.3"
        },
        Offset = 0
    },
    Initial = "IA",
    Author = "Imran Anwar",
    Text = "A new Comment"
});
wordsApi.InsertComment(insertRequest);