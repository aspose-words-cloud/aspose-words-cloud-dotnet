var config = new Configuration { ClientId = "####-####-####-####-####", ClientSecret = "##################" };
var wordsApi = new WordsApi(config);
using var requestDocumentStream = File.OpenRead("Sample.docx");
var updateRequest = new UpdateCommentOnlineRequest(requestDocumentStream, 0, new CommentUpdate()
{
    RangeStart = new DocumentPosition()
    {
        Node = new NodeLink()
        {
            NodeId = "0.3.0"
        },
        Offset = 0
    },
    RangeEnd = new DocumentPosition()
    {
        Node = new NodeLink()
        {
            NodeId = "0.3.0"
        },
        Offset = 0
    },
    Initial = "IA",
    Author = "Imran Anwar",
    Text = "A new Comment"
});
wordsApi.UpdateCommentOnline(updateRequest);