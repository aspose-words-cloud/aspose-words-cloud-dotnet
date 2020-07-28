// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetDocumentStatisticsOnlineRequest.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
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

namespace Aspose.Words.Cloud.Sdk.Model.Requests
{
    using Aspose.Words.Cloud.Sdk.Model;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentStatisticsOnline" /> operation.
    /// </summary>
    public class GetDocumentStatisticsOnlineRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatisticsOnlineRequest"/> class.
        /// </summary>        
        public GetDocumentStatisticsOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatisticsOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="includeComments">Support including/excluding comments from the WordCount. Default value is "false".</param>
        /// <param name="includeFootnotes">Support including/excluding footnotes from the WordCount. Default value is "false".</param>
        /// <param name="includeTextInShapes">Support including/excluding shape's text from the WordCount. Default value is "false".</param>
        public GetDocumentStatisticsOnlineRequest(System.IO.Stream document, bool? includeComments = null, bool? includeFootnotes = null, bool? includeTextInShapes = null)
        {
            this.Document = document;
            this.IncludeComments = includeComments;
            this.IncludeFootnotes = includeFootnotes;
            this.IncludeTextInShapes = includeTextInShapes;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Support including/excluding comments from the WordCount. Default value is "false".
        /// </summary>
        public bool? IncludeComments { get; set; }

        /// <summary>
        /// Support including/excluding footnotes from the WordCount. Default value is "false".
        /// </summary>
        public bool? IncludeFootnotes { get; set; }

        /// <summary>
        /// Support including/excluding shape's text from the WordCount. Default value is "false".
        /// </summary>
        public bool? IncludeTextInShapes { get; set; }
    }
}
