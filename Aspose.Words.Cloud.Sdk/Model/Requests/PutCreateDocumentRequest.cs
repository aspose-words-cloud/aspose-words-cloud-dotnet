// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutCreateDocumentRequest.cs">
//   Copyright (c) 2017 Aspose.Words for Cloud
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutCreateDocument" /> operation.
  /// </summary>  
  public class PutCreateDocumentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutCreateDocumentRequest"/> class.
        /// </summary>        
        public PutCreateDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutCreateDocumentRequest"/> class.
        /// </summary>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="fileName">The file name.</param>
        /// <param name="folder">The document folder.</param>
        public PutCreateDocumentRequest(string storage = null, string fileName = null, string folder = null)             
        {
            this.Storage = storage;
            this.FileName = fileName;
            this.Folder = folder;
        }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }
  }
}
