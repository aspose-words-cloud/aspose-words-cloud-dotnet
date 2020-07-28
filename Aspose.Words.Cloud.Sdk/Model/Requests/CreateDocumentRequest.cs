// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateDocumentRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.CreateDocument" /> operation.
    /// </summary>
    public class CreateDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest"/> class.
        /// </summary>        
        public CreateDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest"/> class.
        /// </summary>
        /// <param name="fileName">The document name.</param>
        /// <param name="folder">The document folder.</param>
        /// <param name="storage">Original document storage.</param>
        public CreateDocumentRequest(string fileName = null, string folder = null, string storage = null)
        {
            this.FileName = fileName;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The document name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Original document storage.
        /// </summary>
        public string Storage { get; set; }
    }
}
