var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
var requestCommentRangeStartNode = new NodeLink()
{
    NodeId = "0.3.0"
};
var requestCommentRangeStart = new DocumentPosition()
{
    Node = requestCommentRangeStartNode,
    Offset = 0
};
var requestCommentRangeEndNode = new NodeLink()
{
    NodeId = "0.3.0"
};
var requestCommentRangeEnd = new DocumentPosition()
{
    Node = requestCommentRangeEndNode,
    Offset = 0
};
var requestComment = new CommentUpdate()
{
    RangeStart = requestCommentRangeStart,
    RangeEnd = requestCommentRangeEnd,
    Initial = "IA",
    Author = "Imran Anwar",
    Text = "A new Comment"
};
var updateRequest = new UpdateCommentRequest("Sample.docx", 0, requestComment);
wordsApi.UpdateComment(updateRequest);