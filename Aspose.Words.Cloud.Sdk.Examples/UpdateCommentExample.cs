// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateCommentExample.cs">
//   Copyright (c) 2021 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Words.Cloud.Sdk;
using Aspose.Words.Cloud.Sdk.Model;
using Aspose.Words.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

[TestFixture]
public partial class ExampleTests
{
    [Test]
    public void ExampleUpdateComment()
    {
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
    }
}