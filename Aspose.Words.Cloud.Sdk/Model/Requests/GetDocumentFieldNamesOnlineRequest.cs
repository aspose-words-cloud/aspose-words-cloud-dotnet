// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetDocumentFieldNamesOnlineRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentFieldNamesOnline" /> operation.
    /// </summary>
    public class GetDocumentFieldNamesOnlineRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentFieldNamesOnlineRequest"/> class.
        /// </summary>        
        public GetDocumentFieldNamesOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentFieldNamesOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="useNonMergeFields">If true, result includes "mustache" field names.</param>
        public GetDocumentFieldNamesOnlineRequest(System.IO.Stream document, bool? useNonMergeFields = null)
        {
            this.Document = document;
            this.UseNonMergeFields = useNonMergeFields;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// If true, result includes "mustache" field names.
        /// </summary>
        public bool? UseNonMergeFields { get; set; }
    }
}
