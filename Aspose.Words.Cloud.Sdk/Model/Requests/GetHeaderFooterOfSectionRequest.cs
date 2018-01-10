// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetHeaderFooterOfSectionRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooterOfSection" /> operation.
  /// </summary>  
  public class GetHeaderFooterOfSectionRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFooterOfSectionRequest"/> class.
        /// </summary>        
        public GetHeaderFooterOfSectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFooterOfSectionRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="headerFooterIndex">Header/footer index.</param>
        /// <param name="sectionIndex">Section index.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="filterByType">List of types of headers and footers.</param>
        public GetHeaderFooterOfSectionRequest(string name, int? headerFooterIndex, int? sectionIndex, string folder = null, string storage = null, string loadEncoding = null, string password = null, string filterByType = null)             
        {
            this.Name = name;
            this.HeaderFooterIndex = headerFooterIndex;
            this.SectionIndex = sectionIndex;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FilterByType = filterByType;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Header/footer index.
        /// </summary>  
        public int? HeaderFooterIndex { get; set; }

        /// <summary>
        /// Section index.
        /// </summary>  
        public int? SectionIndex { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string FilterByType { get; set; }
  }
}
