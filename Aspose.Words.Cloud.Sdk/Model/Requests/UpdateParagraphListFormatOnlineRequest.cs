// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateParagraphListFormatOnlineRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateParagraphListFormatOnline" /> operation.
    /// </summary>
    public class UpdateParagraphListFormatOnlineRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateParagraphListFormatOnlineRequest"/> class.
        /// </summary>        
        public UpdateParagraphListFormatOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateParagraphListFormatOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="listFormatDto">ListFormatUpdate dto.</param>
        /// <param name="index">Object index.</param>
        /// <param name="nodePath">Path to the node which contains paragraphs.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        public UpdateParagraphListFormatOnlineRequest(System.IO.Stream document, ListFormatUpdate listFormatDto, int index, string nodePath = null, string loadEncoding = null, string password = null, string destFileName = null, string revisionAuthor = null, string revisionDateTime = null)
        {
            this.Document = document;
            this.ListFormatDto = listFormatDto;
            this.Index = index;
            this.NodePath = nodePath;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.DestFileName = destFileName;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// ListFormatUpdate dto.
        /// </summary>
        public ListFormatUpdate ListFormatDto { get; set; }

        /// <summary>
        /// Object index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Path to the node which contains paragraphs.
        /// </summary>
        public string NodePath { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>
        public string DestFileName { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>
        public string RevisionDateTime { get; set; }
    }
}
