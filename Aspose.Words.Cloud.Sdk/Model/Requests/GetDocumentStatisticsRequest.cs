// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetDocumentStatisticsRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentStatistics" /> operation.
  /// </summary>  
  public class GetDocumentStatisticsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatisticsRequest"/> class.
        /// </summary>        
        public GetDocumentStatisticsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatisticsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="includeComments">Support including/excluding comments from the WordCount. Default value is \&quot;true\&quot;.</param>
        /// <param name="includeFootnotes">Support including/excluding footnotes from the WordCount. Default value is \&quot;false\&quot;.</param>
        /// <param name="includeTextInShapes">Support including/excluding shape&#39;s text from the WordCount. Default value is \&quot;false\&quot;</param>
        public GetDocumentStatisticsRequest(string name, string folder = null, string storage = null, string loadEncoding = null, string password = null, bool? includeComments = null, bool? includeFootnotes = null, bool? includeTextInShapes = null)             
        {
            this.Name = name;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.IncludeComments = includeComments;
            this.IncludeFootnotes = includeFootnotes;
            this.IncludeTextInShapes = includeTextInShapes;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

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
        /// Support including/excluding comments from the WordCount. Default value is \"true\".
        /// </summary>  
        public bool? IncludeComments { get; set; }

        /// <summary>
        /// Support including/excluding footnotes from the WordCount. Default value is \"false\".
        /// </summary>  
        public bool? IncludeFootnotes { get; set; }

        /// <summary>
        /// Support including/excluding shape's text from the WordCount. Default value is \"false\"
        /// </summary>  
        public bool? IncludeTextInShapes { get; set; }
  }
}
