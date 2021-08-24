var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestCommentRangeStartNode = new NodeLink()
{
    NodeId = "0.3.0.3"
};
var requestCommentRangeStart = new DocumentPosition()
{
    Node = requestCommentRangeStartNode,
    Offset = 0
};
var requestCommentRangeEndNode = new NodeLink()
{
    NodeId = "0.3.0.3"
};
var requestCommentRangeEnd = new DocumentPosition()
{
    Node = requestCommentRangeEndNode,
    Offset = 0
};
var requestComment = new CommentInsert()
{
    RangeStart = requestCommentRangeStart,
    RangeEnd = requestCommentRangeEnd,
    Initial = "IA",
    Author = "Imran Anwar",
    Text = "A new Comment"
};
var insertRequest = new InsertCommentRequest("Sample.docx", requestComment);
wordsApi.InsertComment(insertRequest);